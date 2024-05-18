namespace Shared.Types;

public class ModelWrapper
{
    public List<string>? Errors { get; init; }
    public string Message { get; set; }
    
    public ModelWrapper(string message, IEnumerable<string>? errors = null)
    {
        Message = message;
        Errors = errors?.ToList();
    }

    public ModelWrapper()
    {
        Errors = new List<string>();
        Message = "";
    }

    public bool IsValid => (Errors == null || !Errors.Any());
}

public class ModelWrapper<TModel> : ModelWrapper
{
    public TModel Result { get; init; }
    
    public ModelWrapper(TModel model, string message = "", IEnumerable<string>? errors = null) 
        : base(message, errors)
    {
        Result = model;
    }

    public ModelWrapper()
    {
        
    }
}