use Academia
go

create table TblTurmas
(IdTurma int primary key identity not null,
 DescricaoTurma varchar(50) unique not null,
 MaxAlunos int not null,
 Status char(1) not null,
 Id_Prof int,
 Id_Horario int)
 go

 alter table TblTurmas add constraint FK_Prof_Turma
 foreign key(Id_Prof) references TblProfessores(IdProf)
 go

 alter table TblTurmas add constraint FK_Horario_Turma
 foreign key(Id_Horario) references TblHorarios(IdHorario)
 go

 insert into TblTurmas 
 values('Matemática',20,'A',1,1)
 go

 select * from TblTurmas
 go

 delete from TblTurmas
 go


 exec spListarTurmas
 go

 drop procedure spListarTurmas
 go

 create procedure spListarTurmas
 as begin
 begin tran
 begin try

 select t.IdTurma,
        t.DescricaoTurma,
        t.MaxAlunos,
	    p.NomeProfessor as Professor,
		h.DescricaoHorario as Horario,
		case
		when Status = 'A' then 'Ativa'
		when Status = 'P' then 'Paralisada'
		when status = 'C' then 'Cancelada'
		end as 'Status'

		from TblTurmas t inner join TblProfessores p
		on t.Id_Prof = p.IdProf
		inner join TblHorarios h
		on t.Id_Horario = h.IdHorario
		order by DescricaoTurma asc

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go

 --Procedure de verificar turma
 create procedure spVerificarTurmas
 @DescricaoTurma varchar(50)
  as begin
 begin tran
 begin try

 select * from TblTurmas
 where DescricaoTurma = @DescricaoTurma

  commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go

 --Procedure de inserir
 create procedure spInserirTurmas
 @DescricaoTurma varchar(50),
 @MaxAlunos int,
 @Status char(1),
 @Id_Prof int,
 @Id_Horario int
  as begin
 begin tran
 begin try

 insert into TblTurmas
 values(@DescricaoTurma,@MaxAlunos,@Status,@Id_Prof,@Id_Horario)

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go

 --Procedure de alterar
 create procedure spAlterarTurmas
 @IdTurma int,
 @DescricaoTurma varchar(50),
 @MaxAlunos int,
 @Status char(1),
 @Id_Prof int,
 @Id_Horario int
  as begin
 begin tran
 begin try

 update TblTurmas set DescricaoTurma=@DescricaoTurma,
 MaxAlunos=@MaxAlunos,Status=@Status,Id_Prof=@Id_Prof,@Id_Horario=@Id_Horario
 where IdTurma=@IdTurma

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 

 --Procedure de excluir
 create procedure spExcluirTurmas
 @IdTurma int
  as begin
 begin tran
 begin try

 delete from TblTurmas
 where IdTurma = @IdTurma

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 

 --Procedure de contagem de vagas(procedure não usada)
 create procedure spDiminuirVagas
 @IdAluno int,
 @Status char(1)
  as begin
 begin tran
 begin try

 select COUNT(IdAluno) as 'ContagemVagas'
        from TblTurmas t inner join TblAlunos a
		on t.IdTurma = a.Id_Turma
		where t.Status = 'A' 

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 
