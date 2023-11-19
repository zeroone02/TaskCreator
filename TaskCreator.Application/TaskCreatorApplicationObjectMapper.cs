using AutoMapper;


namespace TaskCreator.Application;
public class TaskCreatorApplicationObjectMapper : Profile
{
    public TaskCreatorApplicationObjectMapper()
    {
        MapTasks();
    }

    private void MapTasks()
    {
        //CreateMap<Coupon, CouponDto>().ReverseMap();
        //CreateMap<Coupon, CreateCouponDto>().ReverseMap()
        //    .Ignore(x => x.Id);

        //CreateMap<Coupon, UpdateCouponDto>().ReverseMap()
        //    .Ignore(x => x.Id);
    }
   
}
