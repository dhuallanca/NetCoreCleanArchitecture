namespace Application.Exceptions
{
    public class NotFoundException(string entityName, int id) : Exception($"{entityName} with id {id} not found.")
    {
    }
}
