namespace adventure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Telefone = c.String(),
                        DtNasc = c.DateTime(nullable: false),
                        Cpf = c.String(),
                        Email = c.String(),
                        DtCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.colaboradores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Cpf = c.String(),
                        Dpto = c.Int(nullable: false),
                        Salario = c.Double(nullable: false),
                        DtAdmissao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.empresas_transporte",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RazaoSocial = c.String(),
                        NomeFantasia = c.String(),
                        Cnpj = c.String(),
                        TipoTransp = c.Int(nullable: false),
                        Responsavel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.responsaveis_empresas", t => t.Responsavel_Id)
                .Index(t => t.Responsavel_Id);
            
            CreateTable(
                "dbo.responsaveis_empresas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Cpf = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.pacotes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cidade = c.String(),
                        Pais = c.String(),
                        Hotel = c.String(),
                        DtPartida = c.DateTime(nullable: false),
                        DtRetorno = c.DateTime(nullable: false),
                        VlrEstadia = c.Double(nullable: false),
                        VlrTransporte = c.Double(nullable: false),
                        AllInclusive = c.Boolean(nullable: false),
                        Empresa_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.empresas_transporte", t => t.Empresa_Id)
                .Index(t => t.Empresa_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.pacotes", "Empresa_Id", "dbo.empresas_transporte");
            DropForeignKey("dbo.EmpTrans", "Responsavel_Id", "dbo.responsaveis_empresas");
            DropIndex("dbo.pacotes", new[] { "Empresa_Id" });
            DropIndex("dbo.empresas_transporte", new[] { "Responsavel_Id" });
            DropTable("dbo.pacotes");
            DropTable("dbo.responsaveis_empresas");
            DropTable("dbo.empresas_transporte");
            DropTable("dbo.colaboradores");
            DropTable("dbo.clientes");
        }
    }
}
