using Restaurant.Web.Dto;

namespace Restaurant.Web.Service.IService
{
    public interface IBaseService
    {
      Task<ResponseDto> SendAsync(RequestDto requestDto);
    }
}
