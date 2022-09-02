use Academia
go

drop table TblFluxoCaixa
go
drop procedure spInserirEntradaSaidaFluxo
go


create table TblFluxoCaixa
(IdFluxo int,
 Data date,
 Tipo varchar(30),
 Descricao varchar(70),
 Entrada decimal(10,2),
 Saida decimal(10,2))
 go

 
 --Procedure de inserir entradas e saidas
 create procedure spInserirEntradaSaidaFluxo
 @IdFluxo int,
 @Data date,
 @Tipo varchar(30),
 @Descricao varchar(70),
 @Entrada decimal(10,2),
 @Saida decimal(10,2)
 as begin
 begin try
 begin tran

 insert into TblFluxoCaixa 
 values(@IdFluxo,@Data,@Tipo,@Descricao,@Entrada,@Saida)

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go
