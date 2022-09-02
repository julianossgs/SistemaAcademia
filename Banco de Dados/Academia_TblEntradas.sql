Use Academia
go


create table TblEntradas
(IdEntrada int primary key identity(100,1),
Data date,
Tipo varchar(30),
Descricao varchar(70),
Valor decimal(10,2))
go

--Procedures
 --Procedure de inserir
 create procedure spInserirEntradas
 @Data date,
 @Tipo varchar(30),
 @Descricao varchar(70),
 @Valor decimal(10,2)
 as begin
 begin try
 begin tran

 insert into TblEntradas values(@Data,@Tipo,@Descricao,@Valor)

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go

 --Procedure de Excluir
 create procedure spExcluirEntradas
 @IdEntrada int
 as begin
 begin try
 begin tran

 delete from TblEntradas
 where IdEntrada = @IdEntrada

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go

 --Procedure de selecionar o valor p/ exclusão
 create procedure spSelecionarValorEntrada
 @Valor decimal(10,2)
 as begin
 begin try
 begin tran

 select Valor from TblEntradas
 where Valor = @Valor

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go


 --Procedure de alterar
 create procedure spAlterarEntradas
 @IdEntrada int,
 @Data date,
 @Tipo varchar(30),
 @Descricao varchar(70),
 @Valor decimal(10,2)
 as begin
 begin try
 begin tran

 update TblEntradas set Data = @Data,
 Tipo= @Tipo,Descricao = @Descricao,Valor = @Valor
 where IdEntrada = @IdEntrada

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go

 --Procedure de buscar
 create procedure spBuscarDatasEntrada
 @DataInicial date,
 @DataFinal date
 as begin
 begin try
 begin tran

 select * from TblEntradas
 where Data >= @DataInicial and Data <= @DataFinal
 order by Data desc

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go

   --Trigger p/ inserir na tab Saida e Movimentações

   create trigger trgInserirEntradaMov
   on TblEntradas
   after insert
   as
   insert into TblMovimentacoes
   select IdEntrada,Data,Tipo,Descricao,Valor
   from inserted
   go

   --Trigger p/ alterar na tab Saída e Movimentações
   create trigger trgAlterarEntradaMov
   on Tblentradas
   for update
   as begin
   declare 
   @IdMov int,
   @IdEntrada int,
   @Data date,
   @Tipo varchar(30),
   @Descricao varchar(70),
   @Valor decimal(10,2)

   select @IdEntrada = IdEntrada,
          @Data = Data,
		  @Tipo = Tipo,
		  @Descricao = Descricao,
		  @Valor = Valor

		  from inserted
		 
   update TblMovimentacoes
   set IdMov= @IdEntrada,Data= @Data, Tipo=@Tipo,Descricao = @Descricao,Valor = @Valor
   where IdMov = @IdEntrada
   end
   go
   

   --Trigger p/ excluir na tab Saída e Movimentacoes
   create trigger trgExcluirEntradaMov
   on TblEntradas
   after delete
   as begin

   declare
   @IdMov int,
   @IdEntrada int,
   @Data date,
   @Tipo varchar(30),
   @Descricao varchar(70),
   @Valor decimal(10,2)

   select @IdEntrada = IdEntrada,
          @Data = Data,
		  @Tipo = Tipo,
		  @Descricao = Descricao,
		  @Valor = Valor
   from deleted
   delete from TblMovimentacoes
   where @IdEntrada = IdMov
   end
   go

   --Trigger p/ inserir na tabe de entrada e Fluxo de caixa
   create trigger tgrInserirEntradaFluxo
   on TblEntradas
   after insert
   as
   insert into TblFluxoCaixa
   select IdEntrada,Data,Tipo,Descricao,Valor
   from inserted
   go



