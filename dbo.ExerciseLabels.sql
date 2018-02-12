CREATE TABLE [dbo].[ExerciseLabels] (
    [ID]    INT            IDENTITY (1, 1) NOT NULL,
    [Label] NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_ExerciseLabels] PRIMARY KEY CLUSTERED ([ID] ASC)
);

