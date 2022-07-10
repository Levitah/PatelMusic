namespace PatelMusic.Services.AlbumAPI.Models.DTO
{
    public class ResponseDto
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; } = string.Empty;
        public object Result { get; set; }
        public List<string> ErrorMessages { get; set; }
    }
}