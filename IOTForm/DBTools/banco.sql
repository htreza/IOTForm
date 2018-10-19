CREATE TABLE Cliente (
	Id INTEGER IDENTITY(0,1) NOT NULL,
	Nome NVARCHAR(100) NOT NULL,

	CONSTRAINT PkClienteId PRIMARY KEY(Id)
);

CREATE TABLE Questionario (
	Id INTEGER IDENTITY(0,1) NOT NULL,
	Questao NVARCHAR NOT NULL
	CONSTRAINT PkQuestionario PRIMARY KEY(Id)
);

CREATE TABLE QuestionarioRespostas(
	Id INTEGER IDENTITY(0,1) NOT NULL,
	IdCliente INTEGER NOT NULL,
	IdQuestao INTEGER NOT NULL,
	Resposta BINARY NULL,
	RespostaTexto NVARCHAR(1024) NULL,

	CONSTRAINT PkQuestionarioRespostas PRIMARY KEY(Id),
	CONSTRAINT FkQuestionario FOREIGN KEY(IdQuestao)
		REFERENCES Questionario(Id),
	CONSTRAINT FkQuestionarioCliente FOREIGN KEY(IdCliente)
		REFERENCES Cliente(Id)
);

CREATE TABLE AtivosDevices (
	Id INTEGER IDENTITY(0,1) NOT NULL,
	IdCliente INTEGER NOT NULL,

	GeralNumeroAtivos TINYINT NOT NULL,
	GeralNumeroAtivosC NTEXT NULL,
	GeralValorAtivo TINYINT NOT NULL,
	GeralValorAtivoC NTEXT NULL,
	GeralValorEconomico TINYINT NOT NULL,
	GeralValorEconomicoC NTEXT NULL,
	GeralComplexidadeAtivo TINYINT NOT NULL,
	GeralComplexidadeAtivoC NTEXT NULL,
	GeralHeteroAtivo TINYINT NOT NULL,
	GeralHeteroAtivoC NTEXT NULL,

	PoderLogicaNegocio TINYINT NOT NULL,
	PoderLogicaNegocioC NTEXT NULL,
	PoderProcessamento TINYINT NOT NULL,
	PoderProcessamentoC NTEXT NULL,
	PoderRequerimentos TINYINT NOT NULL,
	PoderRequerimentosC NTEXT NULL,
	PoderGestaoLocal TINYINT NOT NULL,
	PoderGestaoLocalC NTEXT NULL,

	OutrosFonteEnergia TINYINT NOT NULL,
	OutrosFonteEnergiaC NTEXT NULL,
	OutrosAmbiente TINYINT NOT NULL,
	OutrosAmbienteC NTEXT NULL,

	GestaoVidaUtil TINYINT NOT NULL,
	GestaoVidaUtilC NTEXT NULL,
	GestaoRestricoesHardware TINYINT NOT NULL,
	GestaoRestricoesHardwareC NTEXT NULL,
	GestaoRestricoesSoftware TINYINT NOT NULL,
	GestaoRestricoesSoftwareC NTEXT NULL,

	CONSTRAINT PkAtivosDevices PRIMARY KEY(Id),
	CONSTRAINT FkAtivosDevices FOREIGN KEY(IdCliente)
		REFERENCES Cliente(Id)
);

CREATE TABLE ComunicacaoConectividade(
	Id INTEGER IDENTITY(0,1) NOT NULL,
	IdCliente INTEGER NOT NULL,

	LocalTecnologia TINYINT NOT NULL,
	LocalTecnologiaC NTEXTNULL,
	LocalLarguraBanda TINYINT NOT NULL,
	LocalLarguraBandaC NTEXT NULL,
	LocalMaximaLatencia TINYINT NOT NULL,
	LocalMaximaLatenciaC NTEXT NULL,

	RemotaTecnologia TINYINT NOT NULL,
	RemotaTecnologiaC NTEXT NULL,
	RemotaLarguraBanda TINYINT NOT NULL,
	RemotaLarguraBandaC NTEXT NULL,
	RemotaMaximaLatencia TINYINT NOT NULL,
	RemotaMaximaLatenciaC NTEXT NULL,

	CONSTRAINT PkComunicacaoConectividade PRIMARY KEY(Id),
	CONSTRAINT FKComunicacaoConectividade FOREIGN KEY(IdCliente)
		REFERENCES Cliente(ID)
);

CREATE TABLE ServicosBackend(
	Id INTEGER IDENTITY(0,1) NOT NULL,
	IdCliente INTEGER NOT NULL,

	GeralEstrategiaAplicacao TINYINT NOT NULL,
	GeralEstrategiaAplicacaoC NTEXT NULL,
	GeralComplexidadeNegocio TINYINT NOT NULL,
	GeralComplexidadeNegocioC NTEXT NULL,
	GeralIntegracaoBackend TINYINT NOT NULL,
	GeralIntegracaoBackendC NTEXT NULL,
	GestaoVolumeDados TINYINT NOT NULL,
	GestaoVolumeDadosC NTEXT NULL,
	GestaoVariedadeDados TINYINT NOT NULL,
	GestaoVariedadeDadosC NTEXT	NULL,
	GestaoVariabilidadeDados TINYINT NOT NULL,
	GestaoVariabilidadeDadosC NTEXT NULL,
	GestaoAnalytics TINYINT NOT NULL,
	GestaoAnalyticsC NTEXT NULL,

	CONSTRAINT PkServicosBackend PRIMARY KEY(Id),
	CONSTRAINT FkServicosBackend FOREIGN KEY(IdCliente)
		REFERENCES Cliente(Id)
);

CREATE TABLE PadroesRequerimentos(
	Id INTEGER IDENTITY(0,1) NOT NULL,
	IdCliente INTEGER NOT NULL,

	RequerimentosRegiao TINYINT NOT NULL,
	RequerimentosRegiaoC NTEXT NULL,
	RequerimentosIndustria TINYINT NOT NULL,
	RequerimentosIndustriaC NTEXT NULL,
	RequerimentosTecnologia TINYINT NOT NULL,
	RequerimentosTecnologiaC NTEXT NULL,
	PadroesTecnicos TINYINT NOT NULL,
	PadroesTecnicosC NTEXT NULL,
	PadroesFuncionais TINYINT NOT NULL,
	PadroesFuncionaisC NTEXT NULL,

	CONSTRAINT PkPadroesRequerimentos PRIMARY KEY(Id),
	CONSTRAINT FkPadroesRequerimentos FOREIGN KEY(IdCliente)
		REFERENCES Cliente(Id)
);

CREATE TABLE AmbienteProjeto(
	Id INTEGER IDENTITY(0,1) NOT NULL,
	IdCliente INTEGER NOT NULL,

	AmbienteTempo TINYINT NOT NULL,
	AmbienteTempoC NTEXT NULL,
	AmbienteBudget TINYINT NOT NULL,
	AmbienteBudgetC NTEXT NULL,
	AmbienteFuncionais TINYINT NOT NULL,
	AmbienteFuncionaisC NTEXT NULL,
	AmbienteTecnicas TINYINT NOT NULL,
	AmbienteTecnicasC NTEXT NULL,

	CONSTRAINT PkAmbienteProjeto PRIMARY KEY(Id),
	CONSTRAINT FkAmbienteProjeto FOREIGN KEY(IdCliente)
		REFERENCES Cliente(Id)
);