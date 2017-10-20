using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cookbook
{
    public partial class FormMain : Form
    {
        /*
         * Where the database is, what the credentials are and how to connect to it
         */
        string connectionString;

        SqlConnection connection;

        public FormMain()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Cookbook.Properties.Settings.CookbookConnectionString"].ConnectionString;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            PopulateRecipies();
            PopulateAllIngredients();
            PopulateUsers();

        }

        private void PopulateRecipies()
        {
            /*
             * You can use a using statement with an object that implements 
             * iDesposible and it will automatically close the object for you 
             */
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter sqlDataAdaptor = new SqlDataAdapter("SELECT * FROM Recipe", connection))
            {
                DataTable recipeTable = new DataTable();
                // Fill recipeTable with the results of the table above
                sqlDataAdaptor.Fill(recipeTable);

                listRecipies.DisplayMember = "Name"; // E.g. Salad etc
                listRecipies.ValueMember = "Id"; // I.e. Use the Id column
                listRecipies.DataSource = recipeTable;
            }
        }

        private void PopulateAllIngredients()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter sqlDataAdaptor = new SqlDataAdapter("SELECT * FROM Ingredient", connection))
            {
                DataTable ingredientTable = new DataTable();
                sqlDataAdaptor.Fill(ingredientTable);
                listAllIngredients.DisplayMember = "Name";
                listAllIngredients.ValueMember = "Id";
                listAllIngredients.DataSource = ingredientTable;
            }
        }

        private void PopulateIngredients()
        {

            string query = @"SELECT dbo.Ingredient.Name 
                             FROM dbo.Ingredient
                             INNER JOIN dbo.RecipeIngredient 
                                ON RecipeIngredient.IngredientId = Ingredient.Id 
                             WHERE RecipeId = @RecipeId";
            /*
             * You can use a using statement with an object that implements 
             * iDesposible and it will automatically close the object for you 
             */
            using (connection = new SqlConnection(connectionString))
            // SqlCommand class supports parameters, such as @RecipeId
            using (SqlCommand sqlCommand = new SqlCommand(query, connection))
            // We can use command this time instead   
            using (SqlDataAdapter sqlDataAdaptor = new SqlDataAdapter(sqlCommand))
            {
                sqlCommand.Parameters.AddWithValue("@RecipeId", listRecipies.SelectedValue);
                DataTable ingredientTable = new DataTable();
                // Fill recipeTable with the results of the table above
                sqlDataAdaptor.Fill(ingredientTable);
                listRecipeIngredients.DisplayMember = "Name"; // E.g. Salad etc
                listRecipeIngredients.ValueMember = "Id"; // I.e. Use the Id column
                listRecipeIngredients.DataSource = ingredientTable;
            }
        }

        private void listRecipies_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateIngredients();
        }

        private void buttonAddRecipe_Click(object sender, EventArgs e)
        {
            string query = @"
                            INSERT INTO dbo.Recipe
                            (
                                Name,
                                PreperationTime,
                                Instructions
                            )
                            VALUES
                            (   @RecipeName, -- Name - nvarchar(50)
                                50,   -- PreperationTime - smallint
                                N'Follow instructions'  -- Instructions - nvarchar(max)
                            )";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand sqlCommand = new SqlCommand(query, connection))
            {
                connection.Open();
                sqlCommand.Parameters.AddWithValue("@RecipeName", textRecipeName.Text);
                sqlCommand.ExecuteScalar();
            }
            PopulateRecipies();
        }

        private void buttonUpdateRecipeName_Click(object sender, EventArgs e)
        {
            string query = "UPDATE dbo.Recipe SET Name = @RecipeName WHERE Id = @RecipeID";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand sqlCommand = new SqlCommand(query, connection))
            {
                connection.Open();
                sqlCommand.Parameters.AddWithValue("@RecipeName", textRecipeName.Text);
                sqlCommand.Parameters.AddWithValue("@RecipeId", listRecipies.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            PopulateRecipies();
        }

        private void buttonAddToRecipe_Click(object sender, EventArgs e)
        {
            string query = @"
                            INSERT INTO dbo.RecipeIngredient
                            (
                                RecipeId,
                                IngredientId
                            )
                            VALUES
                            (   
                                @RecipeId, -- int
                                @IngredientId -- int
                            );
            ";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand sqlCommand = new SqlCommand(query, connection))
            {
                connection.Open();
                sqlCommand.Parameters.AddWithValue("@RecipeId", listRecipies.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@IngredientId", listAllIngredients.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            PopulateRecipies();
        }
        private void PopulateUsers()
        {
            ArrayList userList = new ArrayList();

            User user = new User()
            {
                Id = 1,
                Name = "James"
            };

            User user2 = new User()
            {
                Id = 2,
                Name = "Lauren"
            };

            userList.Add(user);
            userList.Add(user2);

            // From User.cs
            listUsers.ValueMember = "Id";
            listUsers.DisplayMember = "Name";
            listUsers.DataSource = userList;
        }
    }



}