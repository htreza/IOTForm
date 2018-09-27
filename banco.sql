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
    GeralNumeroAtivos INTEGER NOT NULL,
    GeralValorAtivo INTEGER NOT NULL,
    GeralValorEconomico INTEGER NOT NULL,
    GeralComplexidadeAtivo INTEGER NOT NULL,
    GeralHetoroAtivo INTEGER NOT NULL,
    
    PoderLogicaNegocio INTEGER NOT NULL,
    PoderProcessamento INTEGER NOT NULL,
    PoderRequerimentos INTEGER NOT NULL,
    PoderGestaoLocal INTEGER NOT NULL,
    
    OutrosFonteEnergia INTEGER NOT NULL,
    OutrosAmbiente INTEGER NOT NULL,
    
    GestaoVidaUtil INTEGER NOT NULL,
    GestaoRestricoesHardware INTEGER NOT NULL,
    GestaoRestricoesSoftware INTEGER NOT NULL,
    
    CONSTRAINT PkAtivosDevices PRIMARY KEY(Id),
    CONSTRAINT FkAtivosDevices FOREIGN KEY(IdCliente)
        REFERENCES Cliente(Id)
);

CREATE TABLE ComunicacaoConectividade(
    Id INTEGER IDENTITY(0,1) NOT NULL,
    IdCliente INTEGER NOT NULL,
    LocalTecnologia INTEGER NOT NULL,
    LocalLarguraBanda INTEGER NOT NULL,
    LocalMaximaLatencia INTEGER NOT NULL,
    RemotaTecnologia INTEGER NOT NULL,
    RemotaLarguraBanda INTEGER NOT NULL,
    RemotaMaximaLatencia INTEGER NOT NULL,
    
    CONSTRAINT PkComunicacaoConectividade PRIMARY KEY(Id),
    CONSTRAINT FKComunicacaoConectividade FOREIGN KEY(IdCliente)
        REFERENCES Cliente(ID)
);

CREATE TABLE ServicosBackend(
    Id INTEGER IDENTITY(0,1) NOT NULL,
    IdCliente INTEGER NOT NULL,
    GeralEstrategiaAplicacao INTEGER NOT NULL,
    GeralComplexidadeNegocio INTEGER NOT NULL,
    GeralIntegracaoBackend INTEGER NOT NULL,
    GestaoVolumeDados INTEGER NOT NULL,
    GestaoVariedadeDados INTEGER NOT NULL,
    GestaoVariabilidadeDados INTEGER NOT NULL,
    GestaoAnalytics INTEGER NOT NULL,
    
    CONSTRAINT PkServicosBackend PRIMARY KEY(Id),
    CONSTRAINT FkServicosBackend FOREIGN KEY(IdCliente)
        REFERENCES Cliente(Id)
    
);

CREATE TABLE PadroesRequerimentos(
    Id INTEGER IDENTITY(0,1) NOT NULL,
    IdCliente INTEGER NOT NULL,
    RequerimentosRegiao INTEGER NOT NULL,
    RequerimentosIndustria INTEGER NOT NULL,
    RequerimentosTecnologia INTEGER NOT NULL,
    PadroesTecnicos INTEGER NOT NULL,
    PadroesFuncionais INTEGER NOT NULL,

    CONSTRAINT PkPadroesRequerimentos PRIMARY KEY(Id),
    CONSTRAINT FkPadroesRequerimentos FOREIGN KEY(IdCliente)
        REFERENCES Cliente(Id)
);

CREATE TABLE AmbienteProjeto(
    Id INTEGER IDENTITY(0,1) NOT NULL,
    IdCliente INTEGER NOT NULL,
    AmbienteTempo INTEGER NOT NULL,
    AmbienteBudget INTEGER NOT NULL,
    AmbienteFuncionais INTEGER NOT NULL,
    AmbienteTecnicas INTEGER NOT NULL,
    
    CONSTRAINT PkAmbienteProjeto PRIMARY KEY(Id),
    CONSTRAINT FkAmbienteProjeto FOREIGN KEY(IdCliente)
        REFERENCES Cliente(Id)
);

CREATE TABLE Comentario(
    Id INTEGER IDENTITY(0,1) NOT NULL,
    IdCampoTabela INTEGER NOT NULL,
    NomeTabela NVARCHAR(40) NOT NULL,
    NomeColuna NVARCHAR(40) NOT NULL,
    Comentario NVARCHAR(1024) NOT NULL,

    CONSTRAINT PkComentario PRIMARY KEY(Id)
);
