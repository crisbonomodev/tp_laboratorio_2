CREATE TABLE [dbo].[Usuarios] (
    [user_Id]   INT          NOT NULL,
    [usuario]   VARCHAR (20) NOT NULL,
    [password]  VARCHAR (32) NOT NULL,
    [user_role] VARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([user_Id] ASC)
);

