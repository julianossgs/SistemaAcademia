use Academia
go

create table TblProfessores
(IdProf int primary key identity not null,
 NomeProfessor varchar(50) not null,
 Telefone varchar(30))
 go

 insert into TblProfessores
 values('Maria Taroba','(35)98818-7733'),
 ('Romildo Taroba','(35)98877-1200')
 go

 --Procedure de listar professores
 create procedure spListarProfessor
 as begin
 begin tran
 begin try

 select * from TblProfessores 
 order by NomeProfessor asc

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go

 --Procedure de listar professor por Nome
 create procedure spListarProfessorNome
 @NomeProfessor varchar(50)
 as begin
 begin tran
 begin try

 select NomeProfessor from TblProfessores 
 where NomeProfessor = @NomeProfessor

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go

 --Procedure de inserir
 create procedure spInserirProfessor
 @NomeProfessor varchar(50),
 @Telefone varchar(30)
 as begin
 begin tran
 begin try

 insert into TblProfessores values(@NomeProfessor,@Telefone)

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go

 --Procedure de alterar
 create procedure spAlterarProfessor
 @IdProf int,
 @NomeProfessor varchar(50),
 @Telefone varchar(30)
  as begin
 begin tran
 begin try

 update TblProfessores
 set NomeProfessor = @NomeProfessor,Telefone = @Telefone
 where IdProf = @IdProf

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go

 --Procedure de excluir
 create procedure spExcluirProfessor
 @IdProf int
  as begin
 begin tran
 begin try

 delete from TblProfessores
 where IdProf = @IdProf

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go