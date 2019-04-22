using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Core;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Diagnostics;
using FundacionTalitaKumi.Modelo;
using System.Windows.Forms;
namespace FundacionTalitaKumi.Controlador
{
    class GeneraPDF
    {
        private void FindAndReplace(Microsoft.Office.Interop.Word.Application doc, object findText, object replaceWithText)
        {

            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundsLike = false;
            object matchAllWordForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiacritics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            try
            {
                doc.Selection.Find.Execute(ref findText, ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundsLike, ref matchAllWordForms, ref forward, ref wrap, ref format, ref replaceWithText, ref replace,
                ref matchKashida, ref matchDiacritics, ref matchAlefHamza, ref matchControl);
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo encontrar y reemplazar: " + ex);
            }

        }
        private void FindAndReplaceTB(Word.Document doc, string Findtext, string ReplaceText)
        {
            Word.Range myStoryRange = doc.Range();


            Word.Find myFind = myStoryRange.Find;
            myFind.Text = Findtext;
            myFind.Replacement.Text = ReplaceText;
            myFind.Forward = true;
            myFind.Wrap = Word.WdFindWrap.wdFindContinue;
            myFind.Format = false;
            myFind.MatchCase = false;
            myFind.MatchWholeWord = false;
            myFind.MatchWildcards = false;
            myFind.MatchSoundsLike = false;
            myFind.MatchAllWordForms = false;
            myFind.Execute(Replace: Word.WdReplace.wdReplaceAll);


            foreach (Word.Range otherStoryRange in doc.StoryRanges)
            {
                if (otherStoryRange.StoryType != Word.WdStoryType.wdMainTextStory)
                {
                    Word.Find myOtherFind = otherStoryRange.Find;
                    myOtherFind.Text = Findtext;
                    myOtherFind.Replacement.Text = ReplaceText;
                    myOtherFind.Wrap = Word.WdFindWrap.wdFindContinue;
                    myOtherFind.Execute(Replace: Word.WdReplace.wdReplaceAll);
                }

                Word.Range nextStoryRange = otherStoryRange.NextStoryRange;
                while (nextStoryRange != null)
                {
                    Word.Find myNextStoryFind = nextStoryRange.Find;
                    myNextStoryFind.Text = Findtext;
                    myNextStoryFind.Replacement.Text = ReplaceText;
                    myNextStoryFind.Wrap = Word.WdFindWrap.wdFindContinue;
                    myNextStoryFind.Execute(Replace: Word.WdReplace.wdReplaceAll);

                    nextStoryRange = nextStoryRange.NextStoryRange;
                }

            }
        }
        public List<int> getRunningProcesses()
        {
            List<int> ProcessIDs = new List<int>();
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (Process.GetCurrentProcess().Id == clsProcess.Id)
                    continue;
                if (clsProcess.ProcessName.Contains("WINWORD"))
                {
                    ProcessIDs.Add(clsProcess.Id);
                }
            }
            return ProcessIDs;
        }
        private void killProcesses(List<int> processesbeforegen, List<int> processesaftergen)
        {
            foreach (int pidafter in processesaftergen)
            {
                bool processfound = false;
                foreach (int pidbefore in processesbeforegen)
                {
                    if (pidafter == pidbefore)
                    {
                        processfound = true;
                    }
                }

                if (processfound == false)
                {
                    Process clsProcess = Process.GetProcessById(pidafter);
                    clsProcess.Kill();
                }
            }
        }

        public void GenerarPDF(object guardarPDF, Beneficiaria b, InformePAINA p, Area a, Personal per, DatosFamiliares d)
        {
            object nombreArchivo = @"C:\Users\Pc\Desktop\PROTOTIPO\Prototipo v1.2\Prototipo v1.1\FundacionTalitaKumi\Informes\informePAINA.doc";
            object guardarComo = @"C:\Users\Pc\Desktop\PROTOTIPO\Prototipo v1.2\Prototipo v1.1\FundacionTalitaKumi\Informes\informePAINA1.doc";
            List<int> processesbeforegen = getRunningProcesses();
            Word.Application word = new Word.Application();
            object miss = Missing.Value;
            Word.Document docWord = null;
            if (File.Exists((string)nombreArchivo))
            {
                object readOnly = false;
                object isVisible = false;
                // word.Visible = false;

                docWord = word.Documents.Open(ref nombreArchivo, ref miss, ref readOnly,
                                              ref miss, ref miss, ref miss,
                                              ref miss, ref miss, ref miss,
                                              ref miss, ref miss, ref miss,
                                              ref miss, ref miss, ref miss, ref miss);
                docWord.Activate();
                DateTime fechaActual = DateTime.Now;
                this.FindAndReplace(word, "<names>", b.NombresBeneficiaria);
                this.FindAndReplace(word, "<age>", fechaActual.Year - b.FechaDeNacimientoBe.Year + "");
                this.FindAndReplace(word, "<dads>", d.NombresFamiliar);
                this.FindAndReplace(word, "<ethnic>", b.EtniaBe);
                this.FindAndReplace(word, "<reason>", "");
                this.FindAndReplace(word, "<Eday>", p.FechaDeRealizacionP);
                this.FindAndReplace(word, "<Nday>", p.FechaProximaEvaluacion);
                this.FindAndReplace(word, "<profAndID>", p.Profesion);
                this.FindAndReplaceTB(docWord, "<purpose>", p.ObjetivoGeneral);
                this.FindAndReplaceTB(docWord, "<supportAreas1>", p.DesarrolloPersonal);
                this.FindAndReplaceTB(docWord, "<supportAreas2>", p.DesarrolloSocial);
                this.FindAndReplaceTB(docWord, "<area>", a.Nombre);
                this.FindAndReplaceTB(docWord, "<diagnosticAreas>", a.Diagnostico);
                this.FindAndReplaceTB(docWord, "<whoAsks>", a.Solicita);
                this.FindAndReplaceTB(docWord, "<areaPurpose>", a.Objetivo);
                this.FindAndReplaceTB(docWord, "<areaActivities>", a.DescripcionActividades);
                this.FindAndReplaceTB(docWord, "<responsability>", a.ResponsablesActividades);
                this.FindAndReplaceTB(docWord, "<time>", a.TiempoActividades);
                this.FindAndReplaceTB(docWord, "<evaluation>", a.Evaluacion);
                this.FindAndReplaceTB(docWord, "<areaObservatio>", a.Observaciones);
                this.FindAndReplaceTB(docWord, "<name1>", per.Nombres);
                this.FindAndReplaceTB(docWord, "<role1>", per.Tipo);
            }
            else
            {
                MessageBox.Show("El archivo origen no existe");
            }
            try
            {
                docWord.SaveAs2(ref guardarComo, ref miss, ref miss, ref miss,
                            ref miss, ref miss, ref miss,
                            ref miss, ref miss, ref miss,
                            ref miss, ref miss, ref miss,
                            ref miss, ref miss, ref miss);
                docWord.SaveAs2(ref guardarPDF, Word.WdSaveFormat.wdFormatPDF);
                docWord.Close();
                word.Quit();
                MessageBox.Show("Archivo creado exitosamente");
                List<int> processesaftergen = getRunningProcesses();
                killProcesses(processesbeforegen, processesaftergen);
                
            }
            catch (Exception ex)
            {
               MessageBox.Show("No se pudo generar el PDF!");
            }



        }
    }
}
