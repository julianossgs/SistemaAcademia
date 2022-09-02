use Academia
go

drop table TblPlanos
go

create table TblPlanos
(IdPlano int primary key identity(100,1) not null,
 Plano varchar(50) unique,
 Valor decimal(10,2),
 Vencimento int,
 DescricaoPlano varchar(100))
 go

 --Procedures
 --Procedure de Listar Planos
 create procedure spListarPlanos
 as begin
 begin tran
 begin try

 select * from TblPlanos
 order by Plano asc

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end 
 go

 drop procedure spSelecionarPlanoNome
 go

 --Procedure de selecionar plano por nome
 create procedure spSelecionarPlanoNome
 @Plano varchar(50)
 as begin
 begin tran
 begin try

 select * from TblPlanos
 where Plano = @Plano 
 
 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end 
 go

 drop procedure spInserirPlanos
 go

 --Procedure de inserir
 create procedure spInserirPlanos
 @Plano varchar(50),
 @Valor decimal(10,2),
 @Vencimento int,
 @DescricaoPlano varchar(100)
 as begin
 begin tran
 begin try

 insert into TblPlanos values(@Plano,@Valor,@Vencimento,@DescricaoPlano)

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end 
 go


 --Procedure de Excluir
 create procedure spExcluirPlanos
 @IdPlano int
 as begin
 begin tran
 begin try

 delete from TblPlanos
 where IdPlano = @IdPlano

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end 
 go

 drop procedure spAlterarPlanos
 go


 --Procedure de inserir
 create procedure spAlterarPlanos
 @IdPlano int,
 @Plano varchar(50),
 @Valor decimal(10,2),
 @Vencimento int,
 @DescricaoPlano varchar(100)
 as begin
 begin tran
 begin try

 update TblPlanos
 set Plano=@Plano,Valor=@Valor,Vencimento=@Vencimento,
 DescricaoPlano=@DescricaoPlano
 where IdPlano = @IdPlano

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end 
 go

 select * from TblPlanos
 go
