namespace MKManager.Helpers
{
    public class Sql
    {
        private string _query { get; set; }
        private string _select { get; set; }
        private string _where { get; set; }
        private string _orderBy { get; set; }

        public Sql() { }

        public Sql(string query) => _query = query;

        public string ObterQuery() => string.IsNullOrEmpty(_query) ? $"{_select} {_where} {_orderBy}".TrimEnd() : _query;

        public void Select(string select) => _select = $"select {select}";

        public void Where(string where) => _where = $"where {where}";

        public void OrderBy(string orderBy) => _orderBy = $"order by {orderBy}";
    }
}