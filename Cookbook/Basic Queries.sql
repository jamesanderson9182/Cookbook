SELECT * FROM dbo.Recipe;

SELECT * FROM dbo.Ingredient;

SELECT dbo.Ingredient.Name FROM dbo.Ingredient 
INNER JOIN dbo.RecipeIngredient 
ON RecipeIngredient.IngredientId = Ingredient.Id 
WHERE RecipeId = 1;

UPDATE dbo.Recipe 
SET Name = 'Salad 4'
WHERE Id = 3;

INSERT INTO dbo.Recipe
(
    Name,
    PreperationTime,
    Instructions
)
VALUES
(   N'Salad', -- Name - nvarchar(50)
    50,   -- PreperationTime - smallint
    N'Combine plenty of stuff'  -- Instructions - nvarchar(max)
);

DELETE FROM dbo.Recipe WHERE Id = 3;