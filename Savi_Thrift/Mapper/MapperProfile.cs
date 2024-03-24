﻿using AutoMapper;
using Savi_Thrift.Application.DTO;
using Savi_Thrift.Application.DTO.AppUser;
using Savi_Thrift.Application.DTO.Group;
using Savi_Thrift.Application.DTO.Saving;
using Savi_Thrift.Application.DTO.Wallet;
using Savi_Thrift.Domain.Entities;
using System.Text.RegularExpressions;

namespace Savi_Thrift.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<KycRequestDto, KYC>().ReverseMap();
            CreateMap<KYC, KycResponseDto>()
            .ForMember(dest => dest.KycId, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.AppUserId))
            .ReverseMap();
            CreateMap<CreateWalletDto, Wallet>().ReverseMap();
            CreateMap<GroupCreationDto, GroupSavings>().ReverseMap();
            CreateMap<GroupResponseDto, GroupSavings>().ReverseMap();
            CreateMap<Wallet, WalletResponseDto>().ReverseMap();
            CreateMap<CreateGoalDto, Saving>().ReverseMap();
            CreateMap<GoalResponseDto, Saving>().ReverseMap();
            CreateMap<RegisterResponseDto, AppUser>().ReverseMap();
            CreateMap<FundWalletDto, WalletFunding>().ReverseMap();
            CreateMap<Saving, CreditSavingsDto>().ReverseMap();
            CreateMap<Saving, GetPersonalSavingsDTO>().ReverseMap();
            CreateMap<GroupSavings, GroupDetailsDto>().ReverseMap();


        }  
    }
}
