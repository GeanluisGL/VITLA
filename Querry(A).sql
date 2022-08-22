CREATE DATABASE VSITLA
--VSITLA Visit System Intituto Tecnológico de las Ámericas
USE VSITLA

---------------------------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------Visit--------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------
CREATE TABLE visit
(
Id INT IDENTITY (1,1) PRIMARY KEY ,
Nombrev NVARCHAR (30) not null,
Apel NVARCHAR(30) not null,
Carrera NVARCHAR(50),
Mail NVARCHAR(50) not null,
Edif INT not null,
AulaR NVARCHAR(15) not null,
Checkin TIME not null,
Checout TIME not null,
MotV NVARCHAR (100) not null,
PhVis NVARCHAR (100) null
)

select * from visit

			--Building
CREATE TABLE Building
(
IDB INT PRIMARY KEY,
NameB NVARCHAR (60),
)	

--DROP TABLE visit
--DROP TABLE classroom

	--Insert
INSERT INTO building VALUES
(0, 'Mecatronica | Edificio 1 ' ),
(1, 'Multimedia | Edificio 2  '),
(2, 'Software | Edificio 3 '),
(3, 'Oficinas | Edificio 4 ')



Create view vwBuilds
as 
SELECT 
IDB as ID,
NameB as 'Edificio'
FROM building

select * from vwBuilds

			--Classroom
CREATE TABLE classroom
(
IDC INT  PRIMARY KEY,
IDB INT  ,
NameC NVARCHAR (25),
CONSTRAINT fk_Building FOREIGN KEY (IDB) 
REFERENCES Building(IDB),
)



INSERT INTO classroom VALUES
(1, 1, 'A11'),
(2, 1, 'A12'),
(3, 1, 'A13'),
(4, 2, 'B21'),
(5, 2, 'B22'),
(6, 2, 'B23'),
(7, 3, 'C31'),
(8, 3, 'C32'),
(9, 3, 'C33'),
(10, 4, 'Oficina academica'),
(11, 4, 'Recursos humanos'),
(12, 4, 'Rectoria')
 	

select * from classroom

	--View
CREATE VIEW  vwVisits
AS
SELECT
	v.Id as ID,
	v.Nombrev as Nombre,
	v.Apel as Apellido,
	v.Edif as 'Id_Edificio',
	b.NameB as Edificio,
	v.AulaR as Aula,
	v.Checkin as 'Hora Entrada',
	v.Carrera as Carrera,
	v.Mail as Correo,
	v.Checout as 'Hora Salida',
	v.MotV as 'Motivo Visita'

FROM visit v
inner join building as b on (v.Edif = b.IDB)


select * from  vwVisits

			--CRUD
CREATE PROCEDURE spComC
@action NVARCHAR (2),
@idC INT
AS
	BEGIN
	SET NOCOUNT ON
		IF(@action = 'BI')
		BEGIN
			SELECT * FROM Building
		END
			IF(@action = 'CR')
		BEGIN
			SELECT IDC, NameC FROM classroom WHERE IDB = @idC
		END
END

exec spComC 'CR', 2

--DROP PROCEDURE spComC



CREATE PROCEDURE sp_CreateC
(
@Nombrev NVARCHAR (30),
@Apel NVARCHAR(30),
@Carrera NVARCHAR(50),
@Mail NVARCHAR(50),
@Edif INT,
@AulaR NVARCHAR(15),
@Checkin TIME,
@Checout TIME,
@MotV NVARCHAR (100),
@PhVis NVARCHAR (100))
AS
BEGIN

INSERT INTO visit (Nombrev, Apel, Carrera, Mail, Edif, AulaR, Checkin, Checout, MotV, PhVis)
VALUES (@Nombrev, @Apel, @Carrera, @Mail, @Edif, @AulaR, @Checkin, @Checout, @MotV, @PhVis)
END 
GO

IF OBJECT_ID('register_Read') IS NOT NULL
BEGIN 
    DROP PROC sp_ReadC
END 
GO
CREATE PROC sp_ReadC
    @name int,
	@user Nvarchar (30)
AS 
BEGIN 
 
    SELECT *
    FROM   vwVisits  
    WHERE  Id_Edificio like @name and Nombre like @user + '%'
END
GO

Exec sp_ReadC 0 , 'Twilight'



IF OBJECT_ID('register_Read') IS NOT NULL
BEGIN 
    DROP PROC sp_ReadCCA
END 
GO
CREATE PROC sp_ReadCCA
    @name int
AS 
BEGIN 
 
    SELECT *
    FROM   vwVisits  
    WHERE  Id_Edificio like @name
END
GO

Exec sp_ReadCCA 1


CREATE PROC		
AS
SELECT 
*
FROM vwBuilds
End 
Go

exec readBuils

IF OBJECT_ID('register_Read') IS NOT NULL
BEGIN 
    DROP PROC sp_ReadCA
END 
GO
CREATE PROC sp_ReadCA
    @name Nvarchar (60)
AS 
BEGIN 
 
    SELECT *
    FROM   vwVisits  
    WHERE  Aula like @name + '%' 
END
GO



IF OBJECT_ID('Register_Update') Is not null
BEGIN
	Drop Proc sp_UpdateC
END 
GO
CREATE PROC sp_UpdateC
	@ID INT,
	@Nombrev NVARCHAR (30),
	@Apel NVARCHAR(30),
	@Carrera NVARCHAR(50),
	@Mail NVARCHAR(50),
	@Edif INT,
	@AulaR NVARCHAR(15),
	@Checkin TIME,
	@Checout TIME,
	@MotV NVARCHAR (100),
	@PhVis NVARCHAR (100)

AS 
BEGIN
		UPDATE visit
		set 
		Nombrev = @Nombrev,
		Apel = @Apel,
		Carrera = @Carrera,
		Mail = @Mail,
		Edif = @Edif,
		AulaR = @AulaR,
		Checkin = @Checkin,
		Checout = @Checout,
		MotV = @MotV,
		PhVis = @PhVis
		Where (Id = @ID)
END
GO


IF OBJECT_ID('register_Delete') IS NOT NULL
BEGIN 
    DROP PROC sp_Delete
END 
GO
CREATE PROC sp_DeleteC
    @ID int
AS 
BEGIN 
 
    DELETE
    FROM   visit  
    WHERE  (Id = @ID) 
END
GO


---------------------------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------Register-----------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------

CREATE TABLE registerU
(
MatricID NVARCHAR (10) PRIMARY KEY,
NameU NVARCHAR (30) not null,
LastNa NVARCHAR (30) not null,
Career NVARCHAR (30) not null,
Mail NVARCHAR (40) not null,
Pword NVARCHAR (15) not null,
UserRole INT null

)

CREATE TABLE Roles
(
ID int primary key,
Roles NVARCHAR (15)
)

INSERT INTO Roles VALUES
(0, 'VISITANTE'),
(1, 'ADMINISTRATOR')

		--View
CREATE VIEW vwregister
AS
SELECT
	r.MatricID as 'Matricula',
	r.NameU as 'Nombre',
	r.LastNa as 'Apellido',	
	r.Career as 'Carrera',
	r.Mail as 'Correo',
	r.UserRole as 'Rol ID',
	ro.Roles as 'Rol'
FROM registerU r
join Roles as ro on (r.UserRole = ro.ID)

select * from registerU

CREATE VIEW vwroles
AS
SELECT 
r.ID as 'ID Role',
r.Roles as 'Role'
FROM Roles r


	--Crud

CREATE PROCEDURE sp_CreateCR
(
@MatricID NVARCHAR (10),
@NameU NVARCHAR (30),
@LastNa NVARCHAR (30),
@Career NVARCHAR (30),
@Mail NVARCHAR (40),
@Pword NVARCHAR (15),
@UserRole INT
)
AS
BEGIN

INSERT INTO registerU (MatricID, NameU, LastNa, Career, Mail, Pword, UserRole)
VALUES (@MatricID, @NameU, @LastNa, @Career, @Mail, @Pword, @UserRole)
END 
GO

IF OBJECT_ID('register_Read') IS NOT NULL
BEGIN 
    DROP PROC sp_ReadCRN
END 
GO
CREATE PROC sp_ReadCRN
    @name Nvarchar (60)
AS 
BEGIN 
 
    SELECT *
    FROM   vwregister  
    WHERE  Nombre like @name + '%' 
END
GO



IF OBJECT_ID('register_Read') IS NOT NULL
BEGIN 
    DROP PROC sp_ReadCRM
END 
GO
CREATE PROC sp_ReadCRM
  
AS 
BEGIN 
 
    SELECT *
    FROM   vwregister  
    
END
GO


IF OBJECT_ID('Register_Update') Is not null
BEGIN
	Drop Proc sp_UpdateCR
END 
GO
CREATE PROC sp_UpdateCR
	@MatricID NVARCHAR (10),
	@NameU NVARCHAR (30),
	@LastNa NVARCHAR (30),
	@Career NVARCHAR (30),
	@Mail NVARCHAR (40),
	@UserRole INT

AS 
BEGIN
		UPDATE registerU
		set 
		NameU = @NameU, 
		LastNa = @LastNa,
		Career = @Career,
		Mail = @Mail,
		UserRole = @UserRole
		Where (MatricID = @MatricID)
END
GO


IF OBJECT_ID('register_Delete') IS NOT NULL
BEGIN 
    DROP PROC sp_DeleteCR
END 
GO
CREATE PROC sp_DeleteCR
    @MatrID NVARCHAR (10)
AS 
BEGIN 
 
    DELETE
    FROM   registerU  
    WHERE  (MatricID = @MatrID) 
END
GO


drop proc sp_ReadCRM
exec sp_DeleteCR '0000-0000'
exec sp_CreateCR '0000-0000', 'Twilight', 'The mask', 'Software', '0000-0000@itla.edu.do', '0000', 1

---------------------------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------Admin--------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------


CREATE PROC sp_logueo
@user NVARCHAR(10),
@clav NVARCHAR(15)
AS
SELECT MatricID, Pword, UserRole, NameU, LastNa, Career, Mail from registerU
where MatricID=@user and Pword=@clav
go


select * from registerU
drop proc sp_logueo '2021-0325', '20210325'
