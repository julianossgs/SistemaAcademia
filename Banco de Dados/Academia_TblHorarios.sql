use Academia
go

create table TblHorarios
(IdHorario int primary key identity not null,
 DescricaoHorario varchar(30))
 go

 insert into TblHorarios values('09:00 até 10:00'),('10:00 até 11:00')

 --Procedure Listar Horários
 create procedure spListarHorarios
 as begin
 begin tran
 begin try

 select * from TblHorarios
 order by DescricaoHorario asc

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go

 --Procedure de Inserir
 create procedure spInserirHorarios
 @DescricaoHorario varchar(30)
  as begin
 begin tran
 begin try

 insert into TblHorarios values(@DescricaoHorario)

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go

 --Procedure de Excluir
 create procedure spExcluirHorarios
 @IdHorario int
   as begin
 begin tran
 begin try

 delete from TblHorarios
 where IdHorario = @IdHorario

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go