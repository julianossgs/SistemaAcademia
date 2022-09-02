use Academia
go

drop table TblMovimentacoes
go


create table TblMovimentacoes
(IdMov int,
 Data date,
 Tipo varchar(30),
 Descricao varchar(70),
 Valor decimal(10,2))
 
 go

 drop procedure spBuscarDatas
 go

 --Procedure de buscar
 create procedure spBuscarDatas
 @DataInicial date,
 @DataFinal date
 as begin
 begin try
 begin tran

 select * from TblMovimentacoes
 where Data >= @DataInicial and Data <= @DataFinal
 order by Data desc

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go

 --Procedure de buscar por datas e tipo
 create procedure spBuscarDataTipo
 @DataInicial date,
 @DataFinal date,
 @Tipo varchar(30)
 as begin
 begin try
 begin tran

 select * from TblMovimentacoes
 where Data >= @DataInicial and Data <= @DataFinal
 and Tipo = @Tipo
 order by Data desc

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go