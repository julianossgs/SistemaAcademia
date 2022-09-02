use Academia
go

create table TblFornecedores
(IdFornec int primary key identity(100,1) not null,
Fornecedor varchar(50) unique not null,
Endereco varchar(50),
Tel varchar(25),
Email varchar(30),
Contato varchar(30),
Cnpj varchar(25) unique not null)
go

--Procedures
--Procedure de Listar/Atualizar
create procedure spListarFornecedores
as begin
begin tran
begin try

select * from TblFornecedores
order by Fornecedor asc

commit tran
end try
begin catch
select ERROR_MESSAGE() as Retorno
end catch
end 
go 

--Procedure de Buscar forneçedor por nome
create procedure spBuscarFornecNome
@Fornecedor varchar(50)
as begin
begin tran
begin try

select * from TblFornecedores
where Fornecedor like @Fornecedor + '%'
order by Fornecedor asc

commit tran
end try
begin catch
select ERROR_MESSAGE() as Retorno
end catch
end 
go 

--Procedure de Listar forneçedor por nome
create procedure spListarFornecNome
@Fornecedor varchar(50)
as begin
begin tran
begin try

select Fornecedor
from TblFornecedores
where Fornecedor = @Fornecedor 

commit tran
end try
begin catch
select ERROR_MESSAGE() as Retorno
end catch
end 
go 

--Procedure de listar fornecedor por Cnpf
create procedure spListarFornecCnpj
@Cnpj varchar(25)
as begin
begin tran
begin try

select Cnpj
from TblFornecedores
where Cnpj = @Cnpj 


commit tran
end try
begin catch
select ERROR_MESSAGE() as Retorno
end catch
end 
go 

--Procedure de Inserir
create procedure spInserirFornec
@Fornecedor varchar(50),
@Endereco varchar(50),
@Tel varchar(25),
@Email varchar(30),
@Contato varchar(30),
@Cnpj varchar(25)
as begin
begin tran
begin try

insert into TblFornecedores
values(@Fornecedor,@Endereco,@Tel,@Email,@Contato,@Cnpj)

commit tran
end try
begin catch
select ERROR_MESSAGE() as Retorno
end catch
end 
go 

--Procedure de Alterar
create procedure spAlterarFornec
@IdFornec int,
@Fornecedor varchar(50),
@Endereco varchar(50),
@Tel varchar(25),
@Email varchar(30),
@Contato varchar(30)
as begin
begin tran
begin try

update TblFornecedores
set Fornecedor = @Fornecedor,Endereco=@Endereco,Tel = @Tel,
Email = @Email
where IdFornec = @IdFornec

commit tran
end try
begin catch
select ERROR_MESSAGE() as Retorno
end catch
end 
go 


--Procedure de Excluir
create procedure spExcluirFornec
@IdFornec int
as begin
begin tran
begin try

delete from TblFornecedores
where IdFornec = @IdFornec

commit tran
end try
begin catch
select ERROR_MESSAGE() as Retorno
end catch
end 
go 

select * from TblFornecedores
go
