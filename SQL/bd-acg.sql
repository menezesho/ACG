CREATE DATABASE BD_ACG
GO

USE BD_ACG
GO

CREATE TABLE ACG(
	ID			INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	NOME		VARCHAR(100),
	HORAS		INT,
	MODALIDADE	VARCHAR(50),
	TIPO		VARCHAR(50)
)

CREATE TABLE ALUNO(
	ID			INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	NOME		VARCHAR(50),
	EMAIL		VARCHAR(50),
	MATRICULA	CHAR(7),
	SENHA		VARCHAR(30)
)

CREATE TABLE ENVIO(
	ID_ACG			INT,
	ID_ALUNO		INT,
	ACEITO			INT,
	FOREIGN KEY (ID_ACG) REFERENCES ACG(ID),
	FOREIGN KEY (ID_ALUNO) REFERENCES ALUNO(ID)
)


INSERT INTO ACG (nome, horas, modalidade, tipo) VALUES ('Combate ao Ass�dio', 3, 'Extens�o Universit�ria','Palestra')
INSERT INTO ALUNO (NOME, EMAIL,MATRICULA,SENHA) VALUES ('Henrique', 'henrique@hotmail.com@', '2121212', '321654')
INSERT INTO ENVIO VALUES (4, 2)

SELECT * FROM ACG
SELECT * FROM ALUNO
SELECT * FROM ENVIO

								--SOMA DAS HORAS TOTAIS DE UM ALUNO ESPEF�FICO

--PROCURA NO BANCO DE DADOS O ID DO ALUNO ATRAVES DA MATRICULA
SELECT ID FROM ALUNO WHERE MATRICULA = '7894561' --RECEBE A MATRICULA DO C#

--PEGA O ID DO CURSO SELECIONADO NO COMBOBOX, JUNTAMENTE COM O ID DO ALUNO IDENTIFICADO ANTERIORMENTE E INSERE NA TABELA 'ENVIO'
INSERT INTO ENVIO VALUES (2, 1)

--FAZ A SOMA DAS HORAS DE ACG ENVIADAS PELO ALUNO X
SELECT SUM(HORAS) AS 'HORA TOTAL' FROM ENVIO JOIN ACG ON ACG.ID = ENVIO.ID_ACG WHERE ENVIO.ID_ALUNO = 1 --@id


--SELECT * FROM ENVIO WHERE FK_ALUNO = 2
--DROP TABLE ACG
--DROP TABLE ALUNO
--DROP TABLE ENVIO


--GERAR RELAT�RIO
SELECT * FROM ALUNO, ACG, ENVIO WHERE ALUNO.ID = ENVIO.ID_ALUNO AND ACG.ID = ENVIO.ID_ACG;
