﻿using API.Data;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;


[Authorize]
public class UsersController : BaseApiController
{
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

    public UsersController(IUserRepository userRepository, IMapper Mapper)
    {
            _mapper = Mapper;
            _userRepository = userRepository;
        
    }


    [HttpGet]  // /api/users/

    public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers()
    {
        var users = await _userRepository.GetMembersAsync();
        
        return Ok(users);
    }

    [HttpGet("{username}")] // /api/users/username

    public async Task<ActionResult<MemberDto>> GetUser(string username)
    {
        return await _userRepository.GetMemberAsync(username);
    }


}
