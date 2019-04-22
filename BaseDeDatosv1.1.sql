	/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     4/7/2018 20:13:10                            */
/*==============================================================*/
use master
CREATE DATABASE TALITAKUMI_BD
GO

USE TALITAKUMI_BD
GO
/*==============================================================*/
/* Table: AREA                                                  */
/*==============================================================*/
create table AREA (
   COD_AREA             		int identity(1,1)    not null,
   NOMBRE						varchar(20)			 not null,
   CODIGO_BENEFICIARIA  		int                  not null,
   COD_INFORME_PAINA    		int                  null,
   INF_CODIGO_BENEFICIARIA 		int                  null,
   COD_INFORME_PGF      		int                  null,
   DIAGNOSTICO          		varchar(1000)        not null,
   OBJETIVO             		varchar(1000)        not null,
   SOLICITA             		varchar(200)         not null,
   RESPONSABLES_ACTIVIDADES 	varchar(500)         not null,
   TIEMPO_ACTIVIDADES   		varchar(200)         not null,
   EVALUACION           		varchar(50)          not null,
   OBSERVACIONES        		varchar(500)         not null,
   constraint PK_AREA primary key nonclustered (COD_AREA)
)
go

/*==============================================================*/
/* Table: AVANCE_GESTION_SOCIAL                                 */
/*==============================================================*/
create table AVANCE_GESTION_SOCIAL (
   COD_AVANCE           int identity(1,1)    not null,
   CODIGO_BENEFICIARIA  int                  not null,
   FECHA_REALIZACION    datetime             not null,
   ACTIVIDAD            varchar(500)         not null,
   LOGRO                varchar(500)         not null,
   constraint PK_AVANCE_GESTION_SOCIAL primary key nonclustered (COD_AVANCE, CODIGO_BENEFICIARIA)
)
go


/*==============================================================*/
/* Table: BENEFICIARIA                                          */
/*==============================================================*/
create table BENEFICIARIA (
   CODIGO_BENEFICIARIA  			int                  not null,
   NUM_CAUSA            			int                  not null,
   NOMBRES              			varchar(100)         not null,
   APELLIDOS            			varchar(100)         not null,
   ETNIA                			varchar(20)          not null,
   NACIONALIDAD         			varchar(50)          not null,
   IDENTIFICACION      		 		varchar(20)          not null,
   FECHA_NACIMIENTO     			datetime             not null,
   LUGAR_NACIMIENTO     			varchar(50)          not null,
   SEXO                 			bit                  not null,
   CORREO_ELECTRONICO   			varchar(100)         null,
   ESTADO_CIVIL         			varchar(20)          null,
   FECHA_ENTRADA        			datetime             not null,
   FECHA_SALIDA         			datetime             null,
   REINSERCION_FAMILIAR 			varchar(500)         null,
   AUTONOMIA            			varchar(500)         null,
   ID_CONTACTO_FAMILIAR_PRINCIPAL 	varchar(20)          not null,
   INSTITUCION_EDUCATIVA_ACTUAL 	varchar(100)         null,
   ANO_ESCOLAR_ACTUAL   			varchar(100)         null,
   ORDEN_JUDICIAL      				bit                  null,
   MOTIVO_INGRESO       			varchar(500)         null,
   CONSUME_DROGAS       			bit                  null,
   PERTENECE_PANDILLAS  			bit                  null,
   EVASION              			varchar(500)         null,
   CALLEJIZACION        			bit                  null,
   DISCAPACIDAD         			bit                  null,
   OBSERVACIONES        			varchar(500)         null,
   TIPO_DISCAPACIDAD    			bit                  null,
   NUM_CARNET_CONADIS   			int                  null,
   TIENE_ENFERMEDAD     			bit                  null,
   TIENE_TRATAMIENTO    			bit                  null,
   NOMBRES_APELLIDOS_DOCTOR 		varchar(200)         null,
   NOMBRE_HOSPITAL      			varchar(100)         null,
   DIRECCION_HOSPITAL   			varchar(200)         null,
   TOMA_MEDICACION      			bit                  null,
   NOMBRE_MEDICACION    			varchar(100)         null,
   HORARIO_MODIFICACION 			datetime             null,
   TOMA_ANTICONCEPTIVOS 			bit                  null,
   NOMBRE_ANTICONCEPTIVO 			varchar(100)         null,
   FECHA_INICIO_ANTICONCEPTIVO 		datetime             null,
   DURACION_TOMA_ANTICONCEPTIVOS 	int                  null,
   constraint PK_BENEFICIARIA primary key nonclustered (CODIGO_BENEFICIARIA)
)
go


/*==============================================================*/
/* Table: DATOS_EDUCATIVOS                                      */
/*==============================================================*/
create table DATOS_EDUCATIVOS (
   CODIGO_BENEFICIARIA  int                  not null,
   NOMBRE_INSTITUCION   varchar(100)         not null,
   TELEFONO_INSTITUCION int                  not null,
   ANOS_CURSADOS        varchar(100)         not null,
   JORNADA              varchar(50)          null,
   DIRECCION			varchar(100)	     not null,
   constraint PK_DATOS_EDUCATIVOS primary key nonclustered (CODIGO_BENEFICIARIA, NOMBRE_INSTITUCION)
)
go


/*==============================================================*/
/* Table: DATOS_FAMILIARES                                      */
/*==============================================================*/
create table DATOS_FAMILIARES (
   CODIGO_BENEFICIARIA  		int                  not null,
   IDENTIFICACION_CONTACTO 		varchar(20)          not null,
   NOMBRES              		varchar(100)         not null,
   APELLIDOS            		varchar(100)         not null,
   FECHA_NACIMIENTO     		datetime             not null,
   NIVEL_EDUCATIVO     			varchar(50)          not null,
   PROFESION            		varchar(50)          null,
   DIRECCION_DOMICILIO  		varchar(200)         not null,
   PARENTESCO           		varchar(50)          not null,
   TELEFONO             		int                  not null,
   SITUACION_LABORAL    		varchar(200)         not null,
   HORARIO_TRABAJO      		varchar(20)          null,
   INGRESO_MENSUAL      		float                null,
   TIENE_DISCAPACIDAD   		bit                  not null,
   OBSERVACIONES        		varchar(500)         null,
   constraint PK_DATOS_FAMILIARES primary key nonclustered (CODIGO_BENEFICIARIA, IDENTIFICACION_CONTACTO)
)
go

/*==============================================================*/
/* Table: DATOS_LABORALES                                       */
/*==============================================================*/
create table DATOS_LABORALES (
   CODIGO_BENEFICIARIA  				int                  not null,
   NOMBRE_INSTITUCION_TRABAJO 			varchar(100)         not null,
   CIUDAD               				varchar(50)          not null,
   LUGAR_TRABAJO        				varchar(100)         not null,
   NOMBRES_APELLIDO_REFERENCIA_LABORAL 	varchar(200)         null,
   CARGO_REFERENCIA_LABORAL 			varchar(50)          null,
   FECHA_INGRESO        				datetime             not null,
   TIPO_TRABAJO         				varchar(25)          not null,
   OBSERVACIONES        				varchar(500)         null,
   constraint PK_DATOS_LABORALES primary key nonclustered (CODIGO_BENEFICIARIA, NOMBRE_INSTITUCION_TRABAJO)
)
go

/*==============================================================*/
/* Table: DATOS_VIVIENDA                                        */
/*==============================================================*/
create table DATOS_VIVIENDA (
   CODIGO_BENEFICIARIA  			int                  not null,
   TIPO_VIVIENDA        			varchar(50)          not null,
   CODICIONES_GENERALES_VIVIENDA 	varchar(50)          not null,
   MATERIAL_VIVIENDA    			varchar(50)          not null,
   POSESION_VIVIENDA    			varchar(50)          not null,
   SV_AGUA              			bit                  not null,
   SV_LUZ               			bit                  not null,
   SV_TELF              			bit                  not null,
   SV_SSHH              			bit                  not null,
   SV_INTERNET          			bit                  not null,
   SV_RECOLECCION_BASURA 			bit                  null,
   SALA                 			bit                  not null,
   COMEDOR              			bit                  not null,
   COCINA               			bit                  not null,
   BANO                 			bit                  not null,
   POZO_SEPTICO         			bit                  not null,
   NUM_DORMITORIOS      			bit                  not null,
   ESTADO_TECHO         			varchar(20)          not null,
   ESTADO_PIDOS         			varchar(20)          not null,
   ESTADO_PAREDES       			varchar(20)          not null,
   ESTADO_PUERTAS       			varchar(20)          not null,
   ESTADO_VENTANAS      			varchar(20)          not null,
   TIPO_BARRIO          			varchar(100)         not null,
   EQUIPAMIENTO_SERVICIOS 			varchar(500)         not null,
   TEJIDO_SOCIAL        			varchar(500)         not null,
   constraint PK_DATOS_VIVIENDA primary key nonclustered (CODIGO_BENEFICIARIA)
)
go


/*==============================================================*/
/* Table: DERECHOS_VULNERADOS                                   */
/*==============================================================*/
create table DERECHOS_VULNERADOS (
   CODIGO_INFORME       int                  not null,
   CODIGO_BENEFICIARIA  int                  not null,
   COD_DERECHO          int identity(1,1)    not null,
   TIPO                 varchar(50)          not null,
   RIESGOS              varchar(500)         not null,
   ACCIONES_REALIZADAS  varchar(500)         not null,
   ACCIONES_FUTURAS     varchar(500)         not null,
   constraint PK_DERECHOS_VULNERADOS primary key nonclustered (CODIGO_INFORME, CODIGO_BENEFICIARIA, COD_DERECHO)
)
go

/*==============================================================*/
/* Table: FICHA_INFO_GENERAL                                    */
/*==============================================================*/
create table FICHA_INFO_GENERAL (
   COD_FICHA            int identity(1,1)    not null,
   CODIGO_BENEFICIARIA  int                  not null,
   OBSERVACIONES        varchar(500)         not null,
   constraint PK_FICHA_INFO_GENERAL primary key nonclustered (COD_FICHA, CODIGO_BENEFICIARIA)
)
go

/*==============================================================*/
/* Table: FICHA_SEGUIMIENTO_LABORAL                             */
/*==============================================================*/
create table FICHA_SEGUIMIENTO_LABORAL (
   CODIGO               			int identity(1,1)    not null,
   CODIGO_BENEFICIARIA  			int                  not null,
   FECHA_REALIZACION    			datetime             not null,
   CUMPLE_RESPONSABILIDADES 		varchar(50)          not null,
   RELACION_LABORAL_COMPANEROS 		varchar(50)          not null,
   CUMPLE_HORARIOS      			varchar(50)          not null,
   CUMPLE_NORMAS        			varchar(50)          not null,
   OBSERVACIONES_EMPLEADOR 			varchar(500)         null,
   RECOMENDACIONES_EMPLEADOR 		varchar(500)         null,
   OBSERVACIONES        			varchar(500)         null,
   constraint PK_FICHA_SEGUIMIENTO_LABORAL primary key nonclustered (CODIGO, CODIGO_BENEFICIARIA)
)
go

/*==============================================================*/
/* Table: FUNDACION                                             */
/*==============================================================*/
create table FUNDACION (
   SEDE_ID              smallint             not null,
   NOMBRE               varchar(100)         not null,
   DIRECCION            varchar(200)         not null,
   TELEFONO             int                  not null,
   constraint PK_FUNDACION primary key nonclustered (SEDE_ID)
)
go


/*==============================================================*/
/* Table: HISTORIAL_CRONOLOGICO                                 */
/*==============================================================*/
create table HISTORIAL_CRONOLOGICO (
   CODIGO_BENEFICIARIA  int                  not null,
   NOMBRE_CASA_ACOGIDA  varchar(100)         not null,
   CIUDAD               varchar(50)          not null,
   FECHA_ENTRADA        datetime             not null,
   FECHA_SALIDA         datetime             not null,
   constraint PK_HISTORIAL_CRONOLOGICO primary key nonclustered (CODIGO_BENEFICIARIA)
)
go

/*==============================================================*/
/* Table: INFORME_PAINA                                         */
/*==============================================================*/
create table INFORME_PAINA (
   CODIGO_BENEFICIARIA  		int					 not null,
   COD_INFORME_PAINA    		int identity(1,1)    not null,
   FECHA_REALIZACION    		datetime             not null,
   FECHA_PROXIMA_EVALUACION 	datetime             not null,
   OBJETIVO_GENERAL     		varchar(500)         not null,
   DESARROLLO_PERSONAL  		varchar(500)         not null,
   DESARROLLO__SOCIAL   		varchar(500)         not null,
   PROFESION					varchar(100)		 null
   constraint PK_INFORME_PAINA primary key nonclustered (CODIGO_BENEFICIARIA, COD_INFORME_PAINA)
)
go

/*==============================================================*/
/* Table: INFORME_PGF                                           */
/*==============================================================*/
create table INFORME_PGF (
   CODIGO_BENEFICIARIA  		int                  not null,
   COD_INFORME_PGF      		int identity(1,1)    not null,
   DIAGNOSTICO_FAMILIA  		varchar(1000)        not null,
   DIAGNOSTICO_EQUIPO   		varchar(1000)        not null,
   OBEJTIVO_GENERAL_FAMILIA 	varchar(500)         not null,
   OBJETIVO_GENERAL_EQUIPO 		varchar(500)         not null,
   DINAMICAS_INTERFAMILIARES 	varchar(500)         not null,
   CONDICIONES_SOCIOCULTURALES 	varchar(500)         not null,
   constraint PK_INFORME_PGF primary key nonclustered (CODIGO_BENEFICIARIA, COD_INFORME_PGF)
)
go



/*==============================================================*/
/* Table: INFORME_SOCIAL                                        */
/*==============================================================*/
create table INFORME_SOCIAL (
   COD_INFORME          			int identity(1,1)    not null,
   CODIGO_BENEFICIARIA  			int                  not null,
   FECHA_REALIZACION    			datetime             not null,
   HISTORIA_RELACIONES_FAMILIARES 	varchar(500)         not null,
   VALOR_ALIMENTACION   			float                not null,
   VALOR_SALUD          			float                not null,
   VALOR_EDUCACION      			float                not null,
   VALOR_TRANSPORTE    				float                not null,
   VALOR_RECREACION     			float                not null,
   VALOR_LUZ            			float                not null,
   VALOR_AGUA           			float                not null,
   VALOR_TELEFONO       			float                not null,
   VALOR_TV_PAGADA      			float                not null,
   VALOR_INTERNER       			float                not null,
   VALOR_OTROS_GASTOS   			float                not null,
   TOTAL_GASTOS_FAMILIARES 			float                not null,
   VALOR_BONO_DESARROLLO_HUMANO 	float                not null,
   VALOR_BECA_EDUCATIVA 			float                not null,
   VALOR_BONO_DISCAPACIDAD 			float                not null,
   VALOR_BONO_JOAQUIN_GALLEGOS_LARA float                not null,
   VALOR_AYUDA_FAMILIAR 			float                not null,
   VALOR_PENSION        			float                not null,
   VALOR_BECAS_ONG      			float                not null,
   VALOR_BECAS_GAD      			float                not null,
   VALOR_OTROS_INGRESOS 			float                not null,
   TOTAL_OTROS_INGRESOS 			float                not null,
   SALUD_GRUPO_FAMILIAR 			varchar(500)         not null,
   CLASIFICACION_ENFERMEDADES 		varchar(500)         not null,
   CONCLUSIONES         			varchar(1000)        null,
   RECOMENDACIONES      			varchar(1000)        null,
   ELABORADO_POR        			varchar(500)         not null,
   REVISADO_POR         			varchar(500)         not null,
   constraint PK_INFORME_SOCIAL primary key nonclustered (COD_INFORME, CODIGO_BENEFICIARIA)
)
go

/*==============================================================*/
/* Table: INFORME_UNICO_A_JUECES                                */
/*==============================================================*/
create table INFORME_UNICO_A_JUECES (
   CODIGO_INFORME       		int identity(1,1)    not null,
   CODIGO_BENEFICIARIA  		int                  not null,
   FECHA_REALIZACION    		datetime             not null,
   TIPO_INFORME         		varchar(50)          not null,
   NOMBRES_APELLIDOS_ENTIDAD 	varchar(200)         not null,
   DIRECCION            		varchar(200)         not null,
   PROVINCIA            		varchar(50)          not null,
   REPRESENTANTE_LEGAL  		varchar(200)         not null,
   TELEFONO             		int                  not null,
   STUACION_FAMILIAR    		varchar(500)         not null,
   CONCLUSIONES         		varchar(1000)        null,
   RECOMENDACIONES      		varchar(1000)        null,
   constraint PK_INFORME_UNICO_A_JUECES primary key nonclustered (CODIGO_INFORME, CODIGO_BENEFICIARIA)
)
go


/*==============================================================*/
/* Table: PERSONAL                                              */
/*==============================================================*/
create table PERSONAL (
   IDENTIFICACION						varchar(20)          not null,
   SEDE_ID              				smallint             null,
   NOMBRES              				varchar(100)         not null,
   APELLIDOS            				varchar(100)         not null,
   LUGAR_NACIMIENTO     				varchar(50)          not null,
   FECHA_NACIMIENTO     				datetime             not null,
   DIRECCION            				varchar(200)         not null,
   ESTADO_CIVIL        					varchar(20)          not null,
   TELF_FIJO            				int                  null,
   TELF_MOVIL           				int                  null,
   TIPO_SANGRE          				varchar(20)          not null,
   CORREO_ELECTRONICO   				varchar(100)         not null,
   NUM_HIJOS            				smallint             null,
   ESTUDIOS_REALIZADOS  				varchar(500)         not null,
   IDENTIFICACION_REFERENTE_FAMILIAR 	varchar(20)          not null,
   NOMBRES_APELLIDOS_REFERENTE_FAMILIAR varchar(200)         not null,
   TELEFONO_REF_FAMILIAR 				int                  not null,
   DIRECCION_REF_FAMILIAR 				varchar(200)         not null,
   FECHA_INICIO_CONTRATO 				datetime             not null,
   TIENE_ENFERMEDAD     				bit                  not null,
   TIPO                 				varchar(30)          not null,
   CONTRASENA           				varchar(128)          not null,
   constraint PK_PERSONAL primary key nonclustered (IDENTIFICACION)
)
go


/*==============================================================*/
/* Table: RESPONSABILIDADES                                     */
/*==============================================================*/
create table RESPONSABILIDADES (
   CODIGO_BENEFICIARIA  			int                  not null,
   NOMBRE_INSTITUCION_TRABAJO 		varchar(100)         not null,
   RESPONSABILIDAD      			varchar(100)         not null,
   constraint PK_RESPONSABILIDADES primary key nonclustered (CODIGO_BENEFICIARIA, NOMBRE_INSTITUCION_TRABAJO)
)
go

/*==============================================================*/
/* Table: RESUMEN_CLINICO                                       */
/*==============================================================*/
create table RESUMEN_CLINICO (
   COD_SESION				int identity(1,1)    not null,
   CODIGO_BENEFICIARIA		int                  not null,
   FECHA_REALIZACION		datetime             not null,
   CONDICION_ACTUAL			varchar(500)         not null,
   QUE_REFIERE				varchar(500)         not null,
   INTERVENCION				varchar(500)         not null,
   INDICACIONES				varchar(500)         not null,
   FECHA_SIGUIENTE_SESION	datetime             not null,
   constraint PK_RESUMEN_CLINICO primary key nonclustered (COD_SESION, CODIGO_BENEFICIARIA)
)
go


/*==============================================================*/
/* Table: TALLER                                                */
/*==============================================================*/
create table TALLER (
   COD_TALLER					int identity(1,1)    not null,
   COD_FICHA					int                  null,
   CODIGO_BENEFICIARIA			int                  null,
   NOMBRE_TALLER				varchar(100)         not null,
   FECHA_REALIZACION			datetime             not null,
   FECHA_FINALIZACION			datetime             not null,
   NOMBRES_PERSONA_RESPONABLE	varchar(100)         not null,
   APELLIDOS_PERSONA_RESPONSABLE varchar(100)         not null,
   CERTIFICADO					bit                  not null,
   constraint PK_TALLER primary key nonclustered (COD_TALLER)
)
go


/*==============================================================*/
/* Table: VACACION                                              */
/*==============================================================*/
create table VACACION (
   IDENTIFICACION			varchar(20)          not null,
   COD_VACACION				int	identity(1,1)				not null,
   FECHA_INICIO				datetime             not null,
   FECHA_FIN				datetime             not null,
   constraint PK_VACACION primary key nonclustered (IDENTIFICACION_PERSONAL, COD_VACACION)
)
go



alter table AREA
   add constraint FK_AREA_CONTIENE_INFORME_ foreign key (CODIGO_BENEFICIARIA, COD_INFORME_PAINA)
      references INFORME_PAINA (CODIGO_BENEFICIARIA, COD_INFORME_PAINA)
go

alter table AREA
   add constraint FK_AREA_CONTIENE__INFORME_ foreign key (INF_CODIGO_BENEFICIARIA, COD_INFORME_PGF)
      references INFORME_PGF (CODIGO_BENEFICIARIA, COD_INFORME_PGF)
go

alter table AVANCE_GESTION_SOCIAL
   add constraint FK_AVANCE_G_SE_LE_ASI_BENEFICI foreign key (CODIGO_BENEFICIARIA)
      references BENEFICIARIA (CODIGO_BENEFICIARIA)
go

alter table DATOS_EDUCATIVOS
   add constraint FK_DATOS_ED_POSEE_BENEFICI foreign key (CODIGO_BENEFICIARIA)
      references BENEFICIARIA (CODIGO_BENEFICIARIA)
go

alter table DATOS_FAMILIARES
   add constraint FK_DATOS_FA_NECESITA_BENEFICI foreign key (CODIGO_BENEFICIARIA)
      references BENEFICIARIA (CODIGO_BENEFICIARIA)
go

alter table DATOS_LABORALES
   add constraint FK_DATOS_LA_TIENE_BENEFICI foreign key (CODIGO_BENEFICIARIA)
      references BENEFICIARIA (CODIGO_BENEFICIARIA)
go

alter table DATOS_VIVIENDA
   add constraint FK_DATOS_VI_DEBE_REGI_BENEFICI foreign key (CODIGO_BENEFICIARIA)
      references BENEFICIARIA (CODIGO_BENEFICIARIA)
go

alter table DERECHOS_VULNERADOS
   add constraint FK_DERECHOS_REPRESENT_INFORME_ foreign key (CODIGO_INFORME, CODIGO_BENEFICIARIA)
      references INFORME_UNICO_A_JUECES (CODIGO_INFORME, CODIGO_BENEFICIARIA)
go


alter table FICHA_INFO_GENERAL
   add constraint FK_FICHA_IN_GENERA_BENEFICI foreign key (CODIGO_BENEFICIARIA)
      references BENEFICIARIA (CODIGO_BENEFICIARIA)
go

alter table FICHA_SEGUIMIENTO_LABORAL
   add constraint FK_FICHA_SE_PUEDE_TEN_BENEFICI foreign key (CODIGO_BENEFICIARIA)
      references BENEFICIARIA (CODIGO_BENEFICIARIA)
go

alter table HISTORIAL_CRONOLOGICO
   add constraint FK_HISTORIA_DEBE_POSE_BENEFICI foreign key (CODIGO_BENEFICIARIA)
      references BENEFICIARIA (CODIGO_BENEFICIARIA)
go

alter table INFORME_PAINA
   add constraint FK_INFORME__PRODUCE_BENEFICI foreign key (CODIGO_BENEFICIARIA)
      references BENEFICIARIA (CODIGO_BENEFICIARIA)
go

alter table INFORME_PGF
   add constraint FK_INFORME__PRODUCE__BENEFICI foreign key (CODIGO_BENEFICIARIA)
      references BENEFICIARIA (CODIGO_BENEFICIARIA)
go

alter table INFORME_SOCIAL
   add constraint FK_INFORME__PRESENTA_BENEFICI foreign key (CODIGO_BENEFICIARIA)
      references BENEFICIARIA (CODIGO_BENEFICIARIA)
go

alter table INFORME_UNICO_A_JUECES
   add constraint FK_INFORME__DEBE_GENE_BENEFICI foreign key (CODIGO_BENEFICIARIA)
      references BENEFICIARIA (CODIGO_BENEFICIARIA)
go

alter table PERSONAL
   add constraint FK_PERSONAL_FORMADA_P_FUNDACIO foreign key (SEDE_ID)
      references FUNDACION (SEDE_ID)
go

alter table RESPONSABILIDADES
   add constraint FK_RESPONSA_REALIZA_DATOS_LA foreign key (CODIGO_BENEFICIARIA, NOMBRE_INSTITUCION_TRABAJO)
      references DATOS_LABORALES (CODIGO_BENEFICIARIA, NOMBRE_INSTITUCION_TRABAJO)
go

alter table RESUMEN_CLINICO
   add constraint FK_RESUMEN__TIENE_SES_BENEFICI foreign key (CODIGO_BENEFICIARIA)
      references BENEFICIARIA (CODIGO_BENEFICIARIA)
go

alter table TALLER
   add constraint FK_TALLER_REGISTRA_FICHA_IN foreign key (COD_FICHA, CODIGO_BENEFICIARIA)
      references FICHA_INFO_GENERAL (COD_FICHA, CODIGO_BENEFICIARIA)
go

alter table VACACION
   add constraint FK_VACACION_POSEE__PERSONAL foreign key (IDENTIFICACION_PERSONAL)
      references PERSONAL (IDENTIFICACION)
go


/*SP*/


/*PERSONAL*/

create procedure sp_InsertPersonal 
   @IDENTIFICACION		 varchar(20),
   @SEDE_ID              smallint,
   @NOMBRES              varchar(100),
   @APELLIDOS            varchar(100),
   @LUGAR_NACIMIENTO     varchar(50),
   @FECHA_NACIMIENTO     datetime,
   @DIRECCION            varchar(200),
   @ESTADO_CIVIL         varchar(20),
   @TELF_FIJO            int,
   @TELF_MOVIL           int,
   @TIPO_SANGRE          varchar(20),
   @CORREO_ELECTRONICO   varchar(100),
   @NUM_HIJOS            smallint,
   @ESTUDIOS_REALIZADOS  varchar(100),
   @IDENTIFICACION_REFERENTE_FAMILIAR varchar(20),
   @NOMBRES_APELLIDOS_REFERENTE_FAMILIAR varchar(200),         
   @TELEFONO_REF_FAMILIAR int,                
   @DIRECCION_REF_FAMILIAR varchar(200),        
   @FECHA_INICIO_CONTRATO datetime,            
   @TIENE_ENFERMEDAD     bit,                  
   @TIPO                 varchar(30),          
   @CONTRASENA           varchar(128)
as
begin
   SET NOCOUNT ON
   INSERT INTO dbo.PERSONAL
   (
	   IDENTIFICACION,
	   SEDE_ID,              
	   NOMBRES,              
	   APELLIDOS,            
	   LUGAR_NACIMIENTO,     
	   FECHA_NACIMIENTO,     
	   DIRECCION,           
	   ESTADO_CIVIL,         
	   TELF_FIJO,           
	   TELF_MOVIL,           
	   TIPO_SANGRE,          
	   CORREO_ELECTRONICO,   
	   NUM_HIJOS,            
	   ESTUDIOS_REALIZADOS,  
	   IDENTIFICACION_REFERENTE_FAMILIAR, 
	   NOMBRES_APELLIDOS_REFERENTE_FAMILIAR,         
	   TELEFONO_REF_FAMILIAR,            
	   DIRECCION_REF_FAMILIAR,      
	   FECHA_INICIO_CONTRATO,        
	   TIENE_ENFERMEDAD,              
	   TIPO,                      
	   CONTRASENA    
   )VALUES
   (
       @IDENTIFICACION,
	   @SEDE_ID,              
	   @NOMBRES,              
	   @APELLIDOS,            
	   @LUGAR_NACIMIENTO,     
	   @FECHA_NACIMIENTO,     
	   @DIRECCION,           
	   @ESTADO_CIVIL,         
	   @TELF_FIJO,           
	   @TELF_MOVIL,           
	   @TIPO_SANGRE,          
	   @CORREO_ELECTRONICO,   
	   @NUM_HIJOS,            
	   @ESTUDIOS_REALIZADOS,  
	   @IDENTIFICACION_REFERENTE_FAMILIAR, 
	   @NOMBRES_APELLIDOS_REFERENTE_FAMILIAR,         
	   @TELEFONO_REF_FAMILIAR,            
	   @DIRECCION_REF_FAMILIAR,      
	   @FECHA_INICIO_CONTRATO,        
	   @TIENE_ENFERMEDAD,              
	   @TIPO,                      
	   @CONTRASENA  
   )
end
go


CREATE PROCEDURE sp_CrearUsuario
	@IDENTIFICACION		varchar(20),
	@PASSWORD			varchar(128)
AS
BEGIN
	INSERT INTO dbo.PERSONAL VALUES(@IDENTIFICACION, 0, 'INVITADO', 'INVITADO', 'INVITADO', '2018-01-01', 'INVITADO', 'INVITADO', 0, 0, 'INVITADO', 'INVITADO', 0, 'INVITADO', 'INVITADO', 'INVITADO', 0, 'INVITADO', '2018-01-01', 1, 'INVITADO', @PASSWORD)
END
GO
		

CREATE PROCEDURE sp_ActualizarPersonal
	@IDENTIFICACION		 varchar(20),
   @SEDE_ID              smallint,
   @NOMBRES              varchar(100),
   @APELLIDOS            varchar(100),
   @LUGAR_NACIMIENTO     varchar(50),
   @FECHA_NACIMIENTO     datetime,
   @DIRECCION            varchar(200),
   @ESTADO_CIVIL         varchar(20),
   @TELF_FIJO            int,
   @TELF_MOVIL           int,
   @TIPO_SANGRE          varchar(20),
   @CORREO_ELECTRONICO   varchar(100),
   @NUM_HIJOS            smallint,
   @ESTUDIOS_REALIZADOS  varchar(100),
   @IDENTIFICACION_REFERENTE_FAMILIAR varchar(20),
   @NOMBRES_APELLIDOS_REFERENTE_FAMILIAR varchar(200),         
   @TELEFONO_REF_FAMILIAR int,                
   @DIRECCION_REF_FAMILIAR varchar(200),        
   @FECHA_INICIO_CONTRATO datetime,            
   @TIENE_ENFERMEDAD     bit,                  
   @TIPO                 varchar(30)
AS
BEGIN
	UPDATE PERSONAL
	SET 
	   SEDE_ID = @SEDE_ID,          
	   NOMBRES = @NOMBRES,            
	   APELLIDOS = @APELLIDOS,            
	   LUGAR_NACIMIENTO=  @LUGAR_NACIMIENTO,     
	   FECHA_NACIMIENTO = @FECHA_NACIMIENTO,     
	   DIRECCION= @DIRECCION,           
	   ESTADO_CIVIL= @ESTADO_CIVIL,        
	   TELF_FIJO= @TELF_FIJO,           
	   TELF_MOVIL= @TELF_MOVIL,           
	   TIPO_SANGRE=	 @TIPO_SANGRE,          
	   CORREO_ELECTRONICO= @CORREO_ELECTRONICO,   
	   NUM_HIJOS= @NUM_HIJOS,            
	   ESTUDIOS_REALIZADOS=	@ESTUDIOS_REALIZADOS,  
	   IDENTIFICACION_REFERENTE_FAMILIAR=  @IDENTIFICACION_REFERENTE_FAMILIAR, 
	   NOMBRES_APELLIDOS_REFERENTE_FAMILIAR =  @NOMBRES_APELLIDOS_REFERENTE_FAMILIAR,        
	   TELEFONO_REF_FAMILIAR = @TELEFONO_REF_FAMILIAR,            
	   DIRECCION_REF_FAMILIAR =	 @DIRECCION_REF_FAMILIAR,      
	   FECHA_INICIO_CONTRATO = @FECHA_INICIO_CONTRATO,        
	   TIENE_ENFERMEDAD = @TIENE_ENFERMEDAD,              
	   TIPO = @TIPO              
	WHERE IDENTIFICACION = @IDENTIFICACION
END
GO


CREATE PROCEDURE sp_ActualizarContrasena
	@IDENTIFICACION		 varchar(20),
	@CONTRASENA           varchar(128)
AS
BEGIN
	UPDATE PERSONAL
	SET CONTRASENA = @CONTRASENA
	WHERE IDENTIFICACION = @IDENTIFICACION
END
GO


CREATE PROCEDURE sp_eliminarPersonal
	@IDENTIFICACION		varchar(20)
AS
BEGIN
	IF EXISTS (SELECT IDENTIFICACION FROM PERSONAL WHERE IDENTIFICACION = @IDENTIFICACION)
		BEGIN
			DELETE FROM PERSONAL
			WHERE IDENTIFICACION = @IDENTIFICACION
		END	
END
GO


/*BENEFICIARIA*/

create procedure sp_InsertBeneficiaria
	   @CODIGO_BENEFICIARIA  int,                  
	   @NUM_CAUSA            int,                  
	   @NOMBRES              varchar(100),
	   @APELLIDOS            varchar(100),
	   @ETNIA                varchar(20),
	   @NACIONALIDAD         varchar(50),
	   @IDENTIFICACION       varchar(20),
	   @FECHA_NACIMIENTO     datetime             ,
	   @LUGAR_NACIMIENTO     varchar(50)          ,
	   @SEXO                 bit                  ,
	   @CORREO_ELECTRONICO   varchar(100)         ,
	   @ESTADO_CIVIL         varchar(20)          ,
	   @FECHA_ENTRADA        datetime             ,
	   @ID_CONTACTO_FAMILIAR_PRINCIPAL varchar(20)          ,
	   @INSTITUCION_EDUCATIVA_ACTUAL varchar(100)         ,
	   @ANO_ESCOLAR_ACTUAL   varchar(100)         ,
	   @DISCAPACIDAD         bit                  ,
	   @OBSERVACIONES        varchar(500)         
as
begin 
   SET NOCOUNT ON
   INSERT INTO dbo.Beneficiaria
   (
	   CODIGO_BENEFICIARIA  ,                  
	   NUM_CAUSA            ,                  
	   NOMBRES              ,         
	   APELLIDOS            ,         
	   ETNIA                ,          
	   NACIONALIDAD         ,          
	   IDENTIFICACION       ,          
	   FECHA_NACIMIENTO     ,             
	   LUGAR_NACIMIENTO     ,          
	   SEXO                 ,                  
	   CORREO_ELECTRONICO   ,         
	   ESTADO_CIVIL         ,          
	   FECHA_ENTRADA        ,         
	   ID_CONTACTO_FAMILIAR_PRINCIPAL ,          
	   INSTITUCION_EDUCATIVA_ACTUAL ,         
	   ANO_ESCOLAR_ACTUAL   ,               
	   DISCAPACIDAD         ,                  
	   OBSERVACIONES        
   )VALUES 
   (
       @CODIGO_BENEFICIARIA  ,                  
	   @NUM_CAUSA            ,                  
	   @NOMBRES              ,         
	   @APELLIDOS            ,         
	   @ETNIA                ,          
	   @NACIONALIDAD         ,          
	   @IDENTIFICACION       ,          
	   @FECHA_NACIMIENTO     ,             
	   @LUGAR_NACIMIENTO     ,          
	   @SEXO                 ,                  
	   @CORREO_ELECTRONICO   ,         
	   @ESTADO_CIVIL         ,          
	   @FECHA_ENTRADA        ,       
	   @ID_CONTACTO_FAMILIAR_PRINCIPAL ,          
	   @INSTITUCION_EDUCATIVA_ACTUAL ,         
	   @ANO_ESCOLAR_ACTUAL   ,           
	   @DISCAPACIDAD         ,                  
	   @OBSERVACIONES        
   )
end
go




/*VACACION*/
create procedure sp_InsertarVacacion
	@IDENTIFICACION				varchar(20),       
	@FECHA_INICIO				datetime,            
	@FECHA_FIN					datetime,
	@VERIFICACION				int OUTPUT
as
begin
	SET NOCOUNT ON
	SET @VERIFICACION = 0;
	DECLARE @numDias int	

	SELECT @numDias = SUM(DATEDIFF(day,FECHA_INICIO, FECHA_FIN))
				   FROM VACACION
				   WHERE (IDENTIFICACION = @IDENTIFICACION) AND (YEAR(@FECHA_INICIO) = YEAR(FECHA_INICIO))
	
	IF(@numDias is NULL)
		BEGIN
			IF (DATEDIFF(day,@FECHA_INICIO, @FECHA_FIN)<=30)
				BEGIN
					INSERT INTO dbo.VACACION 
					VALUES( @IDENTIFICACION, @FECHA_INICIO, @FECHA_FIN)
					SET @VERIFICACION = 1
				END		
		END
	ELSE 
		BEGIN			
			IF ((@numDias + (DATEDIFF(day,@FECHA_INICIO, @FECHA_FIN)))<=30)
				BEGIN
					INSERT INTO dbo.VACACION 
					VALUES( @IDENTIFICACION, @FECHA_INICIO, @FECHA_FIN)
					SET @VERIFICACION = 1
				END  
			ELSE 
				BEGIN
					SET @VERIFICACION = 0
				END	
		END
			
	RETURN
END
GO

CREATE PROCEDURE sp_consultarFechaInicioVacacion
	@FECHA_INICIO 						datetime,
	@FECHA_FIN  						datetime,
	@IDENTIFICACION						varchar(20),
	@VERIFICACION						int OUTPUT

AS
BEGIN
	SELECT IDENTIFICACION, FECHA_INICIO, FECHA_FIN 
	FROM VACACION 
	WHERE IDENTIFICACION = @IDENTIFICACION AND ((FECHA_INICIO <= @FECHA_INICIO AND FECHA_FIN >= @FECHA_INICIO)
		OR  (FECHA_INICIO <= @FECHA_FIN AND FECHA_FIN >= @FECHA_FIN)
		OR 	(@FECHA_INICIO <=FECHA_INICIO AND @FECHA_FIN >= FECHA_FIN))

	IF (@@ROWCOUNT != 0)
		BEGIN
			SET @VERIFICACION = 1
		END
	ELSE
		BEGIN
			SET @VERIFICACION = 0
		END
	RETURN
END
GO


CREATE PROCEDURE sp_ActualizarVacacion
	@IDENTIFICACION				varchar(20),
	@FECHA_INICIO				datetime,            
	@FECHA_FIN					datetime
AS
BEGIN
	UPDATE VACACION
	SET FECHA_INICIO = @FECHA_INICIO, 
	FECHA_FIN = @FECHA_FIN
	WHERE IDENTIFICACION = @IDENTIFICACION
END
GO

CREATE PROCEDURE sp_eliminarVacacion
	@IDENTIFICACION				varchar(20),
	@FECHA_INICIO				datetime,            
	@FECHA_FIN					datetime
AS
BEGIN
	DELETE FROM VACACION
	WHERE IDENTIFICACION = @IDENTIFICACION AND FECHA_INICIO = @FECHA_INICIO AND FECHA_FIN = @FECHA_FIN	
END
GO


/*DATOS FAMILIARES BENEFICIARIAS*/

CREATE PROCEDURE sp_InsertarDatosFamiliares
	@CODIGO_BENEFICIARIA  			int,                 
	@IDENTIFICACION_CONTACTO 		varchar(20),         
	@NOMBRES              			varchar(100),         
	@APELLIDOS            			varchar(100),         
	@FECHA_NACIMIENTO     			datetime,             
	@NIVEL_EDUCATIVO     			varchar(50),       
	@PROFESION            			varchar(50),          
	@DIRECCION_DOMICILIO  			varchar(200),         
	@PARENTESCO           			varchar(50),         
	@TELEFONO             			int,                  
	@SITUACION_LABORAL    			varchar(200),         
	@HORARIO_TRABAJO      			varchar(20),          
	@INGRESO_MENSUAL      			float,               
	@TIENE_DISCAPACIDAD   			bit,                  
	@OBSERVACIONES        			varchar(500) 
AS
BEGIN
	SET NOCOUNT ON
	INSERT INTO DATOS_FAMILIARES
	VALUES(
		@CODIGO_BENEFICIARIA,
		@IDENTIFICACION_CONTACTO,
		@NOMBRES,
		@APELLIDOS,
		@FECHA_NACIMIENTO,
		@NIVEL_EDUCATIVO,
		@PROFESION,
		@DIRECCION_DOMICILIO,
		@PARENTESCO,
		@TELEFONO,
		@SITUACION_LABORAL,
		@HORARIO_TRABAJO,
		@INGRESO_MENSUAL,
		@TIENE_DISCAPACIDAD,
		@OBSERVACIONES	
	)
END
GO



/*DATOS EDUCATIVOS*/
CREATE PROCEDURE sp_InsertarDatosEducativos 
	@CODIGO_BENEFICIARIA  			int,
	@NOMBRE_INSTITUCION				varchar(100),    
    @TELEFONO_INSTITUCION			int,    
    @ANOS_CURSADOS					varchar(100),
    @JORNADA						varchar(50),
	@DIRECCION						varchar(100)   
AS
BEGIN
	SET NOCOUNT ON
	INSERT INTO DATOS_EDUCATIVOS
	VALUES(
		@CODIGO_BENEFICIARIA,
		@NOMBRE_INSTITUCION,
		@TELEFONO_INSTITUCION,
		@ANOS_CURSADOS,
		@JORNADA,
		@DIRECCION
	)
END
GO


/*DAR DE BAJA A BENEFICIARIA*/

CREATE PROCEDURE sp_DarDeBajaBeneficiaria
	@CODIGO_BENEFICIARIA int,
	@FECHA_SALIDA	datetime
AS
BEGIN
	UPDATE BENEFICIARIA 
	SET FECHA_SALIDA = @FECHA_SALIDA
	WHERE CODIGO_BENEFICIARIA = @CODIGO_BENEFICIARIA
END
GO

/*Reingresar a la Beneficiaria*/
CREATE PROCEDURE sp_ReingresarBeneficiaria
	@CODIGO_BENEFICIARIA int,
	@FECHA_ENTRADA	datetime
AS
BEGIN
	UPDATE BENEFICIARIA 
	SET FECHA_ENTRADA = @FECHA_ENTRADA
	WHERE CODIGO_BENEFICIARIA = @CODIGO_BENEFICIARIA
END
GO


/*Actualizar Datos Familiares*/
CREATE PROCEDURE sp_ActualizarDatosFamiliares
	@CODIGO_BENEFICIARIA  			int,                 
	@IDENTIFICACION_CONTACTO 		varchar(20),         
	@NOMBRES              			varchar(100),         
	@APELLIDOS            			varchar(100),         
	@FECHA_NACIMIENTO     			datetime,             
	@NIVEL_EDUCATIVO     			varchar(50),       
	@PROFESION            			varchar(50),          
	@DIRECCION_DOMICILIO  			varchar(200),         
	@PARENTESCO           			varchar(50),         
	@TELEFONO             			int,                  
	@SITUACION_LABORAL    			varchar(200),         
	@HORARIO_TRABAJO      			varchar(20),          
	@INGRESO_MENSUAL      			float,               
	@TIENE_DISCAPACIDAD   			bit,                  
	@OBSERVACIONES        			varchar(500) 
AS
BEGIN
	SET NOCOUNT ON
	UPDATE DATOS_FAMILIARES
	SET NOMBRES = @NOMBRES,
		APELLIDOS = @APELLIDOS,
		FECHA_NACIMIENTO = @FECHA_NACIMIENTO,
		NIVEL_EDUCATIVO = @NIVEL_EDUCATIVO,
		PROFESION = @PROFESION,
		DIRECCION_DOMICILIO = @DIRECCION_DOMICILIO,
		PARENTESCO =  @PARENTESCO,
		TELEFONO = @TELEFONO,
		SITUACION_LABORAL = @SITUACION_LABORAL,
		HORARIO_TRABAJO = @HORARIO_TRABAJO,
		INGRESO_MENSUAL = @INGRESO_MENSUAL,
		TIENE_DISCAPACIDAD = @TIENE_DISCAPACIDAD,
		OBSERVACIONES = @OBSERVACIONES	
	WHERE CODIGO_BENEFICIARIA = @CODIGO_BENEFICIARIA AND IDENTIFICACION_CONTACTO = @IDENTIFICACION_CONTACTO
	
END
GO



/*Actualizar Datos Educativos*/
CREATE PROCEDURE sp_ActualizarDatosEducativos 
	@CODIGO_BENEFICIARIA  			int,
	@NOMBRE_INSTITUCION				varchar(100),    
    @TELEFONO_INSTITUCION			int,    
    @ANOS_CURSADOS					varchar(100),
    @JORNADA						varchar(50), 
	@DIRECCION						varchar(100)
AS
BEGIN
	SET NOCOUNT ON
	UPDATE DATOS_EDUCATIVOS
	SET TELEFONO_INSTITUCION =  @TELEFONO_INSTITUCION,
		ANOS_CURSADOS =  @ANOS_CURSADOS,
		JORNADA =  @JORNADA,
		DIRECCION = @DIRECCION
	WHERE CODIGO_BENEFICIARIA = @CODIGO_BENEFICIARIA AND NOMBRE_INSTITUCION = @NOMBRE_INSTITUCION
END
GO

/*Actualizar Datos Beneficiarias*/
create procedure sp_ActualizarBeneficiaria
	   @CODIGO_BENEFICIARIA  int,                  
	   @NUM_CAUSA            int,                  
	   @NOMBRES              varchar(100),
	   @APELLIDOS            varchar(100),
	   @ETNIA                varchar(20),
	   @NACIONALIDAD         varchar(50),
	   @IDENTIFICACION       varchar(20),
	   @FECHA_NACIMIENTO     datetime             ,
	   @LUGAR_NACIMIENTO     varchar(50)          ,
	   @SEXO                 bit                  ,
	   @CORREO_ELECTRONICO   varchar(100)         ,
	   @ESTADO_CIVIL         varchar(20)          ,
	   @FECHA_ENTRADA        datetime             ,
	   @ID_CONTACTO_FAMILIAR_PRINCIPAL varchar(20)          ,
	   @INSTITUCION_EDUCATIVA_ACTUAL varchar(100)         ,
	   @ANO_ESCOLAR_ACTUAL   varchar(100)         ,
	   @DISCAPACIDAD         bit                  ,
	   @OBSERVACIONES        varchar(500)         
as
begin 
   SET NOCOUNT ON
   UPDATE BENEFICIARIA
   SET NUM_CAUSA =     @NUM_CAUSA,   
	   NOMBRES = @NOMBRES,         
	   APELLIDOS = @APELLIDOS,         
	   ETNIA = @ETNIA,          
	   NACIONALIDAD = @NACIONALIDAD,          
	   IDENTIFICACION =  @IDENTIFICACION,          
	   FECHA_NACIMIENTO = @FECHA_NACIMIENTO,             
	   LUGAR_NACIMIENTO = @LUGAR_NACIMIENTO,          
	   SEXO = @SEXO,                  
	   CORREO_ELECTRONICO = @CORREO_ELECTRONICO,         
	   ESTADO_CIVIL = @ESTADO_CIVIL,          
	   FECHA_ENTRADA = @FECHA_ENTRADA,       
	   ID_CONTACTO_FAMILIAR_PRINCIPAL = @ID_CONTACTO_FAMILIAR_PRINCIPAL,          
	   INSTITUCION_EDUCATIVA_ACTUAL = @INSTITUCION_EDUCATIVA_ACTUAL,         
	   ANO_ESCOLAR_ACTUAL = @ANO_ESCOLAR_ACTUAL,           
	   DISCAPACIDAD = @DISCAPACIDAD,                  
	   OBSERVACIONES = @OBSERVACIONES        
   WHERE CODIGO_BENEFICIARIA = @CODIGO_BENEFICIARIA 
end
go


/*INSERTAR INFORME PAINA*/
CREATE PROCEDURE sp_InsertarPAINA
	@CODIGO_BENEFICIARIA	int,
	@FECHA_REALIZACION		datetime,
	@FECHA_PROXIMA_EVALUACION datetime,
	@OBJETIVO_GENERAL		varchar(500),
	@DESARROLLO_PERSONAL	varchar(500),
	@DESARROLLO__SOCIAL		varchar(500),
	@PROFESION				varchar(100)
AS
BEGIN
	INSERT INTO INFORME_PAINA VALUES (@CODIGO_BENEFICIARIA, @FECHA_REALIZACION, @FECHA_PROXIMA_EVALUACION, @OBJETIVO_GENERAL, @DESARROLLO_PERSONAL, @DESARROLLO__SOCIAL, @PROFESION)	
END
GO

/*INSERTAR AREA*/
CREATE PROCEDURE sp_InsertarArea
	@NOMBRE			varchar(20),
	@CODIGO_BENEFICIARIA	int,
	@DIAGNOSTICO			varchar(1000),
	@OBJETIVO				varchar(1000),
	@SOLICITA				varchar(200),
	@RESPONSABLES_ACTIVIDADES	varchar(500),
	@TIEMPO_ACTIVIDADES			varchar(200),
	@EVALUACION					varchar(50),
	@OBSERVACIONES				varchar(500)
AS
BEGIN
	INSERT INTO AREA(NOMBRE, CODIGO_BENEFICIARIA, DIAGNOSTICO, OBJETIVO, SOLICITA, RESPONSABLES_ACTIVIDADES, TIEMPO_ACTIVIDADES, EVALUACION, OBSERVACIONES)
	VALUES (@NOMBRE, @CODIGO_BENEFICIARIA, @DIAGNOSTICO, @OBJETIVO, @SOLICITA, @RESPONSABLES_ACTIVIDADES, @TIEMPO_ACTIVIDADES, @EVALUACION, @OBSERVACIONES)
END
GO


/*INSERTAR RESUMEN CLÍNICO*/
CREATE PROCEDURE sp_InsertarResumenClinico
	@CODIGO_BENEFICIARIA	int,
	@FECHA_REALIZACION		datetime,
	@CONDICION_ACTUAL		varchar(500),
	@QUE_REFIERE			varchar(500),
	@INTERVENCION			varchar(500),
	@INDICACIONES			varchar(500),
	@FECHA_SIGUIENTE_SESION datetime
AS
BEGIN
	INSERT INTO RESUMEN_CLINICO VALUES(@CODIGO_BENEFICIARIA, @FECHA_REALIZACION, @CONDICION_ACTUAL, @QUE_REFIERE, @INTERVENCION, @INDICACIONES, @FECHA_SIGUIENTE_SESION)
END
GO


SELECT * FROM INFORME_PAINA WHERE CODIGO_BENEFICIARIA = 1

