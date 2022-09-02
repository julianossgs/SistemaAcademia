create database Academia
go

use Academia
go

create table TblUsuarios
(IdUsuario int primary key identity not null,
 NomeUsuario varchar(50),
 UserName varchar(20) unique,
 SenhaUsuario char(4) unique,
 StatusUsuario char(1),
 NivelUsuario int)
 go

 select * from TblUsuarios
 go

 insert into TblUsuarios
 values('Juliano','jpc','1234','A',3)

 create procedure spLogar
 @UserName varchar(20),
 @SenhaUsuario char(4)
 as begin
 begin tran
 begin try

 select * from TblUsuarios
 where UserName = @UserName and SenhaUsuario = @SenhaUsuario

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go

 --Procedure de Listar usuários
 create procedure spListarUsuarios
 as begin
 begin tran
 begin try

 select * from TblUsuarios
 order by NomeUsuario asc

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go

 --Procedure de inserir usuários
 create procedure spInserirUsuarios
 @NomeUsuario varchar(50),
 @UserName varchar(20),
 @SenhaUsuario char(4),
 @StatusUsuario char(1),
 @NivelUsuario int
 as begin
 begin tran
 begin try

 insert into TblUsuarios
 values(@NomeUsuario,@UserName,@SenhaUsuario,@StatusUsuario,@NivelUsuario)

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go

 --Procedure verificar senha
 create procedure spVerificarSenha
 @SenhaUsuario char(4)
  as begin
 begin tran
 begin try

 select * from TblUsuarios
 where SenhaUsuario = @SenhaUsuario


 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go

 --Procedure verificar UserName
 create procedure spVerificarUserName
 @UserName varchar(20)
  as begin
 begin tran
 begin try

 select * from TblUsuarios
 where UserName = @UserName

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go

 --Procedure verificar Nome do usuário p/ excluir
 create procedure spVerificarNomeUsuario
 @NomeUsuario varchar(50)
 as begin
 begin tran
 begin try

 select NomeUsuario from TblUsuarios
 where NomeUsuario = @NomeUsuario

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go

 --Procedure de excluir
 create procedure spExcluirUsuario
 @IdUsuario int
 as begin
 begin tran
 begin try

delete from TblUsuarios
where IdUsuario = @IdUsuario

  commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go
