namespace BlabberApp.Domain
{
    public interface IDataStore
    {
        //CRUD
        bool Create(IDatum datum);
        IDatum Read(ISpecimen specimen);
        bool Update(IDatum datum);
        bool Delete(ISpecimen specimen);

    }
}