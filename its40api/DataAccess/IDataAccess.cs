namespace its40api.DataAccess
{
    using System.Collections.Generic;

    public interface IDataAccess<T> where T: class
    {
        List<T> GetList(string whereClause, object filters = null);
    }
}
