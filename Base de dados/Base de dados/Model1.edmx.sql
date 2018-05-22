
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/22/2018 13:35:10
-- Generated from EDMX file: C:\Users\formando\Desktop\ProjetoCSharp2018\Base de dados\Base de dados\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [imodadb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ArrendamentoSet'
CREATE TABLE [dbo].[ArrendamentoSet] (
    [idArrendamento] int IDENTITY(1,1) NOT NULL,
    [InicioContrato] datetime  NOT NULL,
    [DuracaoMeses] decimal(18,0)  NOT NULL,
    [Renovável] bit  NOT NULL,
    [Cliente_idCliente] int  NOT NULL,
    [CasaArrendavel_idCasa] int  NULL
);
GO

-- Creating table 'ClienteSet'
CREATE TABLE [dbo].[ClienteSet] (
    [idCliente] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [NIF] int  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Contacto] int  NOT NULL
);
GO

-- Creating table 'ServiçoSet'
CREATE TABLE [dbo].[ServiçoSet] (
    [idServiço] int IDENTITY(1,1) NOT NULL,
    [Descrição] nvarchar(max)  NOT NULL,
    [Valor] decimal(18,0)  NOT NULL,
    [Unidades] int  NOT NULL,
    [Limpeza_idLimpeza] int  NULL
);
GO

-- Creating table 'LimpezaSet'
CREATE TABLE [dbo].[LimpezaSet] (
    [idLimpeza] int IDENTITY(1,1) NOT NULL,
    [Data] datetime  NOT NULL,
    [Casa_idCasa] int  NULL
);
GO

-- Creating table 'VendaSet'
CREATE TABLE [dbo].[VendaSet] (
    [idVenda] int IDENTITY(1,1) NOT NULL,
    [DataVenda] datetime  NOT NULL,
    [ValorNegociado] decimal(18,0)  NOT NULL,
    [ComissaoNegocial] decimal(18,0)  NOT NULL,
    [Cliente_idCliente] int  NOT NULL,
    [CasaVendavel_idCasa] int  NOT NULL
);
GO

-- Creating table 'CasaSet'
CREATE TABLE [dbo].[CasaSet] (
    [idCasa] int IDENTITY(1,1) NOT NULL,
    [Localidade] nvarchar(max)  NOT NULL,
    [Rua] nvarchar(max)  NOT NULL,
    [Numero] int  NOT NULL,
    [Andar] int  NOT NULL,
    [Area] decimal(18,0)  NOT NULL,
    [NumeroAssoalhada] int  NOT NULL,
    [NumeroWC] int  NOT NULL,
    [NumeroPisos] int  NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL,
    [Cliente_idCliente] int  NOT NULL
);
GO

-- Creating table 'CasaSet_CasaArrendavel'
CREATE TABLE [dbo].[CasaSet_CasaArrendavel] (
    [ValorBaseMes] decimal(18,0)  NOT NULL,
    [Comissão] decimal(18,0)  NOT NULL,
    [idCasa] int  NOT NULL
);
GO

-- Creating table 'CasaSet_CasaVendavel'
CREATE TABLE [dbo].[CasaSet_CasaVendavel] (
    [ValorBaseVenda] decimal(18,0)  NOT NULL,
    [ValorComissao] decimal(18,0)  NOT NULL,
    [idCasa] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [idArrendamento] in table 'ArrendamentoSet'
ALTER TABLE [dbo].[ArrendamentoSet]
ADD CONSTRAINT [PK_ArrendamentoSet]
    PRIMARY KEY CLUSTERED ([idArrendamento] ASC);
GO

-- Creating primary key on [idCliente] in table 'ClienteSet'
ALTER TABLE [dbo].[ClienteSet]
ADD CONSTRAINT [PK_ClienteSet]
    PRIMARY KEY CLUSTERED ([idCliente] ASC);
GO

-- Creating primary key on [idServiço] in table 'ServiçoSet'
ALTER TABLE [dbo].[ServiçoSet]
ADD CONSTRAINT [PK_ServiçoSet]
    PRIMARY KEY CLUSTERED ([idServiço] ASC);
GO

-- Creating primary key on [idLimpeza] in table 'LimpezaSet'
ALTER TABLE [dbo].[LimpezaSet]
ADD CONSTRAINT [PK_LimpezaSet]
    PRIMARY KEY CLUSTERED ([idLimpeza] ASC);
GO

-- Creating primary key on [idVenda] in table 'VendaSet'
ALTER TABLE [dbo].[VendaSet]
ADD CONSTRAINT [PK_VendaSet]
    PRIMARY KEY CLUSTERED ([idVenda] ASC);
GO

-- Creating primary key on [idCasa] in table 'CasaSet'
ALTER TABLE [dbo].[CasaSet]
ADD CONSTRAINT [PK_CasaSet]
    PRIMARY KEY CLUSTERED ([idCasa] ASC);
GO

-- Creating primary key on [idCasa] in table 'CasaSet_CasaArrendavel'
ALTER TABLE [dbo].[CasaSet_CasaArrendavel]
ADD CONSTRAINT [PK_CasaSet_CasaArrendavel]
    PRIMARY KEY CLUSTERED ([idCasa] ASC);
GO

-- Creating primary key on [idCasa] in table 'CasaSet_CasaVendavel'
ALTER TABLE [dbo].[CasaSet_CasaVendavel]
ADD CONSTRAINT [PK_CasaSet_CasaVendavel]
    PRIMARY KEY CLUSTERED ([idCasa] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Cliente_idCliente] in table 'ArrendamentoSet'
ALTER TABLE [dbo].[ArrendamentoSet]
ADD CONSTRAINT [FK_ClienteArrendamento]
    FOREIGN KEY ([Cliente_idCliente])
    REFERENCES [dbo].[ClienteSet]
        ([idCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteArrendamento'
CREATE INDEX [IX_FK_ClienteArrendamento]
ON [dbo].[ArrendamentoSet]
    ([Cliente_idCliente]);
GO

-- Creating foreign key on [CasaArrendavel_idCasa] in table 'ArrendamentoSet'
ALTER TABLE [dbo].[ArrendamentoSet]
ADD CONSTRAINT [FK_ArrendamentoCasaArrendavel]
    FOREIGN KEY ([CasaArrendavel_idCasa])
    REFERENCES [dbo].[CasaSet_CasaArrendavel]
        ([idCasa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArrendamentoCasaArrendavel'
CREATE INDEX [IX_FK_ArrendamentoCasaArrendavel]
ON [dbo].[ArrendamentoSet]
    ([CasaArrendavel_idCasa]);
GO

-- Creating foreign key on [Cliente_idCliente] in table 'CasaSet'
ALTER TABLE [dbo].[CasaSet]
ADD CONSTRAINT [FK_ClienteCasa]
    FOREIGN KEY ([Cliente_idCliente])
    REFERENCES [dbo].[ClienteSet]
        ([idCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteCasa'
CREATE INDEX [IX_FK_ClienteCasa]
ON [dbo].[CasaSet]
    ([Cliente_idCliente]);
GO

-- Creating foreign key on [Cliente_idCliente] in table 'VendaSet'
ALTER TABLE [dbo].[VendaSet]
ADD CONSTRAINT [FK_ClienteVenda]
    FOREIGN KEY ([Cliente_idCliente])
    REFERENCES [dbo].[ClienteSet]
        ([idCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteVenda'
CREATE INDEX [IX_FK_ClienteVenda]
ON [dbo].[VendaSet]
    ([Cliente_idCliente]);
GO

-- Creating foreign key on [Casa_idCasa] in table 'LimpezaSet'
ALTER TABLE [dbo].[LimpezaSet]
ADD CONSTRAINT [FK_CasaLimpeza]
    FOREIGN KEY ([Casa_idCasa])
    REFERENCES [dbo].[CasaSet]
        ([idCasa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CasaLimpeza'
CREATE INDEX [IX_FK_CasaLimpeza]
ON [dbo].[LimpezaSet]
    ([Casa_idCasa]);
GO

-- Creating foreign key on [Limpeza_idLimpeza] in table 'ServiçoSet'
ALTER TABLE [dbo].[ServiçoSet]
ADD CONSTRAINT [FK_LimpezaServiço]
    FOREIGN KEY ([Limpeza_idLimpeza])
    REFERENCES [dbo].[LimpezaSet]
        ([idLimpeza])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LimpezaServiço'
CREATE INDEX [IX_FK_LimpezaServiço]
ON [dbo].[ServiçoSet]
    ([Limpeza_idLimpeza]);
GO

-- Creating foreign key on [CasaVendavel_idCasa] in table 'VendaSet'
ALTER TABLE [dbo].[VendaSet]
ADD CONSTRAINT [FK_VendaCasaVendavel]
    FOREIGN KEY ([CasaVendavel_idCasa])
    REFERENCES [dbo].[CasaSet_CasaVendavel]
        ([idCasa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VendaCasaVendavel'
CREATE INDEX [IX_FK_VendaCasaVendavel]
ON [dbo].[VendaSet]
    ([CasaVendavel_idCasa]);
GO

-- Creating foreign key on [idCasa] in table 'CasaSet_CasaArrendavel'
ALTER TABLE [dbo].[CasaSet_CasaArrendavel]
ADD CONSTRAINT [FK_CasaArrendavel_inherits_Casa]
    FOREIGN KEY ([idCasa])
    REFERENCES [dbo].[CasaSet]
        ([idCasa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [idCasa] in table 'CasaSet_CasaVendavel'
ALTER TABLE [dbo].[CasaSet_CasaVendavel]
ADD CONSTRAINT [FK_CasaVendavel_inherits_Casa]
    FOREIGN KEY ([idCasa])
    REFERENCES [dbo].[CasaSet]
        ([idCasa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------