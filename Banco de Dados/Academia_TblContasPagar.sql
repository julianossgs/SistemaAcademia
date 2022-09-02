use Academia
go

drop table TblContasPagas
go

create table TblContasPagas
(IdContasPagas int,
 Data date,
 Tipo varchar(30),
 Descricao varchar(70),
 Valor decimal(10,2),
 Fornecedor varchar(50))
 go



create table TblContasPagar
(IdContasPagar int primary key identity(100,1),
 Data date,
 Tipo varchar(30),
 Descricao varchar(70),
 Valor decimal(10,2),
 Id_Fornec int)
 go

 alter table TblContasPagar add constraint FK_Contas_Fornecedor
 foreign key(Id_Fornec) references TblFornecedores(IdFornec)
 go

 --Procedures
 --Listar contas a pagar
 create procedure spBuscarContasPagar
 @DataInicial date,
 @DataFinal date
 as begin
 begin try
 begin tran

 select c.IdContasPagar,
        c.Data,
		c.Tipo,
		c.Descricao,
		c.Valor,
		f.Fornecedor
        from TblContasPagar c inner join TblFornecedores f
		on c.Id_Fornec = f.IdFornec
        where Data >= @DataInicial and Data <= @DataFinal
        order by Data desc

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go

 drop procedure spBuscarContasPagas
 go

 --Procedure de buscar contas PAGAS por datas
 create procedure spBuscarContasPagas
  @DataInicial date,
 @DataFinal date
 as begin
 begin try
 begin tran

 select c.IdContasPagas,
        c.Data,
		c.Tipo,
		c.Descricao,
		c.Valor,
		f.Fornecedor 
        from TblContasPagas c inner join TblFornecedores f
		on c.IdContasPagas = f.IdFornec
        where Data >= @DataInicial and Data <= @DataFinal
        order by Data desc

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go



 create procedure spListarContasPagarValor
@Valor decimal(10,2)
as begin
begin tran
begin try

select Valor
from TblContasPagar
where Valor = @Valor 

commit tran
end try
begin catch
select ERROR_MESSAGE() as Retorno
end catch
end 
go 

 --Procedure de inserir
 create procedure spInserirContasPagar
 @Data date,
 @Tipo varchar(30),
 @Descricao varchar(70),
 @Valor decimal(10,2),
 @Id_Fornec int
 as begin
 begin try
 begin tran

 insert into TblContasPagar
 values(@Data,@Tipo,@Descricao,@Valor,@Id_Fornec)

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go

 drop procedure spAlterarContasPagar
 go

 --Procedure de alterar
 create procedure spAlterarContasPagar
 @IdContasPagar int,
 @Data date,
 @Tipo varchar(30),
 @Descricao varchar(70),
 @Valor decimal(10,2),
 @Id_Fornec int
 as begin
 begin try
 begin tran

 update TblContasPagar
 set Data=@Data,Tipo=@Tipo,Descricao=@Descricao,
 Valor=@Valor,Id_Fornec = @Id_Fornec
 where IdContasPagar=@IdContasPagar

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go

 --Procedure de excluir
 create procedure spExcluirContasPagar
 @IdContasPagar int
 as begin
 begin try
 begin tran

 delete from TblContasPagar
 where IdContasPagar = @IdContasPagar

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go

 drop trigger trgExcluirContasMov
 go

 --Trigger
 create trigger trgExcluirContas
 on TblContasPagar
 after delete
 as begin

 declare
 @IdContasPagar int,
 @Data date,
 @Tipo varchar(30),
 @Descricao varchar(70),
 @Valor decimal(10,2),
 @Id_Fornec int

		select @IdContasPagar = IdContasPagar,
		       @Data = Data,
			   @Tipo = Tipo,
			   @Descricao = Descricao,
			   @Valor = Valor,
			   @Id_Fornec = Id_Fornec

		from deleted
		insert into TblContasPagas
		values(@IdContasPagar,@Data,@Tipo,@Descricao,@Valor,@Id_Fornec)
	    end
		go

--Trigger
create trigger trgExcluirContasMov
on TblContasPagar
 after delete
 as begin

 declare
 @IdContasPagar int,
 @Data date,
 @Tipo varchar(30),
 @Descricao varchar(70),
 @Valor decimal(10,2)

		select @IdContasPagar = IdContasPagar,
		       @Data = Data,
			   @Tipo = Tipo,
			   @Descricao = Descricao,
			   @Valor = Valor
			
		from deleted
		insert into TblMovimentacoes
		values(@IdContasPagar,@Data,@Tipo,@Descricao,@Valor)
	    end
		go