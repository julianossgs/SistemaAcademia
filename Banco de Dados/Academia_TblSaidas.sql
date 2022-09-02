use Academia
go

create table TblSaidas
(IdSaida int primary key identity(100,1) not null,
 Data date,
 Tipo varchar(30),
 Descricao varchar(70),
 Valor decimal(10,2))
 go

 --Procedures
 --Procedure de inserir
 create procedure spInserirSaidas
 @Data date,
 @Tipo varchar(30),
 @Descricao varchar(70),
 @Valor decimal(10,2)
 as begin
 begin try
 begin tran

 insert into TblSaidas values(@Data,@Tipo,@Descricao,@Valor)

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go

 --Procedure de Excluir
 create procedure spExcluirSaidas
 @IdSaida int
 as begin
 begin try
 begin tran

 delete from TblSaidas
 where IdSaida = @IdSaida

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go

 --Procedure de selecionar o valor p/ exclusão
 create procedure spSelecionarValorSaida
 @Valor decimal(10,2)
 as begin
 begin try
 begin tran

 select Valor from TblSaidas
 where Valor = @Valor

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go


 --Procedure de alterar
 create procedure spAlterarSaidas
 @IdSaida int,
 @Data date,
 @Tipo varchar(30),
 @Descricao varchar(70),
 @Valor decimal(10,2)
 as begin
 begin try
 begin tran

 update TblSaidas set Data = @Data,
 Tipo= @Tipo,Descricao = @Descricao,Valor = @Valor
 where IdSaida = @IdSaida

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go

 --Procedure de buscar
 create procedure spBuscarDatasSaida
 @DataInicial date,
 @DataFinal date
 as begin
 begin try
 begin tran

 select * from TblSaidas
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

   create trigger trgInserirSaidaMov
   on TblSaidas
   after insert
   as
   insert into TblMovimentacoes
   select IdSaida,Data,Tipo,Descricao,Valor
   from inserted
   go

   --Trigger p/ alterar na tab Saída e Movimentações
   create trigger trgAlterarSaidaMov
   on TblSaidas
   for update
   as begin
   declare 
   @IdMov int,
   @IdSaida int,
   @Data date,
   @Tipo varchar(30),
   @Descricao varchar(70),
   @Valor decimal(10,2)

   select @IdSaida = IdSaida,
          @Data = Data,
		  @Tipo = Tipo,
		  @Descricao = Descricao,
		  @Valor = Valor

		  from inserted
		 
   update TblMovimentacoes
   set IdMov= @IdSaida,Data= @Data, Tipo=@Tipo,Descricao = @Descricao,Valor = @Valor
   where IdMov = @IdSaida
   end
   go
   

   --Trigger p/ excluir na tab Saída e Movimentacoes
   create trigger trgExcluirSaidaMov
   on TblSaidas
   after delete
   as begin

   declare
   @IdMov int,
   @IdSaida int,
   @Data date,
   @Tipo varchar(30),
   @Descricao varchar(70),
   @Valor decimal(10,2)

   select @IdSaida = IdSaida,
          @Data = Data,
		  @Tipo = Tipo,
		  @Descricao = Descricao,
		  @Valor = Valor
   from deleted
   delete from TblMovimentacoes
   where @IdSaida = IdMov
   end
   go
