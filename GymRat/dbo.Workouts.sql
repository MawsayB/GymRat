CREATE TABLE [dbo].[Workouts] (
    [WorkoutID]   INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NULL,
    [UserID]      NVARCHAR (MAX) NULL,
    [Description] NVARCHAR(MAX)    NULL,
    [ExerciseID]  INT            NULL,
    CONSTRAINT [PK_Workouts] PRIMARY KEY CLUSTERED ([WorkoutID] ASC)
);

