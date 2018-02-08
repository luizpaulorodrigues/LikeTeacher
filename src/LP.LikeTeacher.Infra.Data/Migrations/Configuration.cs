

    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    namespace LP.LikeTeacher.Infra.Data.Migrations
{ 
    internal sealed class Configuration : DbMigrationsConfiguration<LP.LikeTeacher.Infra.Data.Context.LikeTeacherContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(LP.LikeTeacher.Infra.Data.Context.LikeTeacherContext context)
        {
           
        }
    }
}
