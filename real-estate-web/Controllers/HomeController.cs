﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using real_estate_web.Models.ViewModel;
using real_estate_web.Data.Abstract;
using real_estate_web.Models.Database.Dtos;
using AutoMapper;

namespace real_estate_web.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAgentRepository _agentRepository;
        private readonly IMapper _mapper;

        public HomeController(ILogger<HomeController> logger,IAgentRepository agentRepository,IMapper mapper)
        {
            _logger = logger;
            _agentRepository = agentRepository;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            IEnumerable<AgentDto> allAgents = _agentRepository.GetListAgentDto().Where(x=>x.IsFavoritUser);
            IEnumerable<AgentVM> agentVMs = _mapper.Map<IEnumerable<AgentVM>>(allAgents);
            
            return View(Tuple.Create<IEnumerable<AgentVM>>(agentVMs));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}