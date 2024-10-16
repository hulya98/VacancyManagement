namespace VacancyManagement.Web
{
    public class ApiResult<T>
    {
        public T Data { get; set; }
        public bool Success { get; set; } = true;
        public List<string> Errors { get; set; } = new List<string>();
        public bool HasErrors => Errors.Any();
        public string ViewName { get; set; }
    }
}
