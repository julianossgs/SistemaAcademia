use Academia
go

select * from TblProdutos
go


create table TblProdutos
(IdProduto int primary key identity(100,1) not null,
 Produto varchar(50) not null,
 Unid varchar(20),
 Estoque decimal(10,2),
 PrecoCusto decimal(10,2),
 PrecoVenda decimal(10,2),
 DataCompra varchar(15),
 Id_Fornec int)
 go

 alter table TblProdutos add constraint FK_Produto_Fornecedor
 foreign key(Id_Fornec) references TblFornecedores(IdFornec)
 go


 --Procedures
 --Listar produtos
 create procedure spListarProdutos
 as begin
 begin tran
 begin try

 select p.IdProduto,
        p.Produto,
		p.Unid,
		p.Estoque,
		p.PrecoCusto,
		p.PrecoVenda,
		p.DataCompra,
		f.Fornecedor,
		f.Contato,
		f.Email,
		f.Tel
		from TblProdutos p inner join TblFornecedores f
		on p.Id_Fornec = f.IdFornec
		order by Produto asc

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end 
 go

 --Procedure de Listar produtos por nome
 create procedure spListarProdutoNome
 @Produto varchar(50)
 as begin
 begin tran
 begin try

 select Produto from TblProdutos
 where Produto = @Produto

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end 
 go



 --Procedure de buscar produtos por nome
 create procedure spBuscarProdutoNome
 @Produto varchar(50)
 as begin
 begin tran
 begin try

 select p.IdProduto,
        p.Produto,
		p.Unid,
		p.Estoque,
		p.PrecoCusto,
		p.PrecoVenda,
		p.DataCompra,
		f.Fornecedor,
		f.Contato,
		f.Email,
		f.Tel
		from TblProdutos p inner join TblFornecedores f
		on p.Id_Fornec = f.IdFornec
		where Produto like @Produto + '%'

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end 
 go

 --Procedure de inserir
 create procedure spInserirProdutos
 @Produto varchar(50),
 @Unid varchar(20),
 @Estoque decimal(10,2),
 @PrecoCusto decimal(10,2),
 @PrecoVenda decimal(10,2),
 @DataCompra varchar(15),
 @Id_Fornec int
 as begin
 begin tran
 begin try

 insert into TblProdutos values
 (@Produto,@Unid,@Estoque,@PrecoCusto,@PrecoVenda,@DataCompra,@Id_Fornec)

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end 
 go

 --Procedure de excluir
 create procedure spExcluirProdutos
 @IdProduto int
 as begin
 begin tran
 begin try

 delete from TblProdutos
 where IdProduto = @IdProduto

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end 
 go

 drop procedure spAlterarProdutos
 go

 --Procedure de alterar
 create procedure spAlterarProdutosEstoque
 @IdProduto int,
 @DataCompra varchar(15),
 @PrecoCusto decimal(10,2),
 @Estoque decimal(10,2),
 @Id_Fornec int
 as begin
 begin tran
 begin try

 update TblProdutos
 set Estoque = @Estoque,PrecoCusto=@PrecoCusto,DataCompra=@DataCompra,
 Id_Fornec = @Id_Fornec
 where IdProduto = @IdProduto

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end 
 go

 --Procedure de alterar p/ cadastro
 create procedure spAlterarProdutos
 @IdProduto int,
 @DataCompra varchar(15),
 @Produto varchar(50),
 @Unid varchar(20),
 @Id_Fornec int
 as begin
 begin tran
 begin try

 update TblProdutos
 set Unid = @Unid,Produto=@Produto,DataCompra=@DataCompra,
 Id_Fornec = @Id_Fornec
 where IdProduto = @IdProduto

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end 
 go
