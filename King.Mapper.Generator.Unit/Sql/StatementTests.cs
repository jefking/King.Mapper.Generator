namespace King.Mapper.Generator.Unit.Sql
{
    using King.Mapper.Generator.Sql;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StatementTests
    {
        [TestMethod]
        public void SelectSchema()
        {
            var sql = Statement.SelectSchema;
            Assert.IsTrue(sql.Contains("[Parameter]"));
            Assert.IsTrue(sql.Contains("[DataType]"));
            Assert.IsTrue(sql.Contains("[Schema]"));
            Assert.IsTrue(sql.Contains("[StoredProcedure]"));
            Assert.IsTrue(sql.Contains("[MaxLength]"));
        }
    }
}