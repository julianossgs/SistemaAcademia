use Academia
go



create table TblAlunos
(IdAluno int primary key identity(100,1) not null,
 NomeAluno varchar(50) not null,
 Telefone varchar(20),
 Email varchar(30),
 Status char(1),
 Id_Turma int,
 Imagem image)
 go

 alter table TblAlunos add constraint FK_Aluno_Turma
 foreign key (Id_Turma) references TblTurmas(IdTurma)
 go

 drop procedure spListarAlunos
 go


 --Procedures

 --Procedure de Listar alunos
 create procedure spListarAlunos
 as begin
 begin tran
 begin try

 select a.IdAluno,
        a.NomeAluno as 'Aluno',
		a.Telefone,
		a.Email,
		a.Status,
		t.DescricaoTurma as 'Turma',
		a.Imagem
		from TblAlunos a inner join TblTurmas t
		on a.Id_Turma = t.IdTurma
		order by NomeAluno asc

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 

 drop procedure spBuscarAlunoNome
 go


 --Procedure de buscar alunos por nome
 create procedure spBuscarAlunoNome
 @NomeAluno varchar(50)
 as begin
 begin tran
 begin try

 select a.IdAluno,
        a.NomeAluno as 'Aluno',
		a.Telefone,
		a.Email,
		a.Status,
		t.DescricaoTurma as 'Turma',
		a.Imagem
		from TblAlunos a inner join TblTurmas t
		on a.Id_Turma = t.IdTurma
		where a.NomeAluno like @NomeAluno + '%'
		order by NomeAluno asc

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 

 --Procedure p/ carregar o combox de turmas
 create procedure spCarregarCBTurmas
  as begin
 begin tran
 begin try

 select IdTurma,
        DescricaoTurma as 'Turma',
		MaxAlunos,
		Status
		from TblTurmas

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 

 drop procedure spInserirAlunos
 go

 --Procedure de inserir
 create procedure spInserirAlunos
 @NomeAluno varchar(50),
 @Telefone varchar(20),
 @Email varchar(30),
 @Status char(1),
 @Id_Turma int,
 @Imagem image
 as begin
 begin tran
 begin try

 insert into TblAlunos
 values(@NomeAluno,@Telefone,@Email,@Status,@Id_Turma,@Imagem)

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go

 drop procedure spAlterarAlunos
 go

 --Procedure de alterar
 create procedure spAlterarAlunos
 @IdAluno int,
 @NomeAluno varchar(50),
 @Telefone varchar(20),
 @Email varchar(30),
 @Status char(1),
 @Id_Turma int,
 @Imagem image
 as begin
 begin tran
 begin try

 update TblAlunos
 set NomeAluno = @NomeAluno,Telefone = @Telefone,
 Email = @Email,Status = @Status,Id_Turma = @Id_Turma,
 Imagem = @Imagem
 where IdAluno = @IdAluno

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 

 --Procedure de alterar sem o parametro da imagem
 create procedure spAlterouAlunosSemImagem
 @IdAluno int,
 @NomeAluno varchar(50),
 @Telefone varchar(20),
 @Email varchar(30),
 @Status char(1),
 @Id_Turma int
 
 as begin
 begin tran
 begin try

 update TblAlunos
 set NomeAluno = @NomeAluno,Telefone = @Telefone,
 Email = @Email,Status = @Status,Id_Turma = @Id_Turma
 where IdAluno = @IdAluno

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 


 --Procedure de excluir
 create procedure spExcluirAlunos
 @IdAluno int
 as begin
 begin tran
 begin try

 delete from TblAlunos
 where IdAluno = @IdAluno

  commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go

 --Procedure selecionar o Nome do Aluno p/ exclusão
 create procedure spSelecionarAlunoNome
 @NomeAluno varchar(50)
 as begin
 begin tran
 begin try

 select NomeAluno from TblAlunos
 where NomeAluno = @NomeAluno

  commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go

 select * from TblAlunos
 go

 /* Sabendo-se que Status é uma lista de opções com os valores:
  Aberto, Fechado, Aguardando Informações e Executando;
  Como ficaria a pesquisa se fosse necessário 
  trazer somente os Casos que não estão fechados e como seria feita a ordenação pelo Número do Caso? */

  select Id,Numero_Caso,Status,Assunto,Descricao
  from TblCasos
  where Status = 'A'
  order by Numero_Caso asc










  create table TblCasos
  (Id int primary key identity,
   Numero_Caso int,
   Status char(1),
   Assunto varchar(10),
   Descricao varchar(10))

   select * from TblCasos
   go


   insert into TblCasos values(1,'A','bbbb','bbbb'),(2,'A','cccc','cccc'),(3,'F','dddd','dddd')
