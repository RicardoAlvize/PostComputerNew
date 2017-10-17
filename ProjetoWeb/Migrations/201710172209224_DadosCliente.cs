namespace ProjetoWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DadosCliente : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Clientes ( Nome, Sobrenome, Cpf, Telefone) VALUES ( 'Ricardo', 'Alvize', 6546446, 92119535)");
            Sql("INSERT INTO Clientes ( Nome, Sobrenome, Cpf, Telefone) VALUES ( 'Gabriela', 'Franc', 6546446, 92119535)");
        }
        
        public override void Down()
        {
        }
    }
}
