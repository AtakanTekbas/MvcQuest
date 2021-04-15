using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Odevler.Data;
using Odevler.Models;
using Odevler.Services.IRepository;
using Odevler.Services.Repository;

namespace Odevler.Controllers
{
    [Area("Teams")]
    public class TeamController : Controller
    {
        private readonly ITeamRepository _teamRepository;
        private readonly IPlayerRepository _playerRepository;
        private readonly ICountryRepository _countryRepository;
        private readonly IPositionRepository _positionRepository;

        public TeamController (ApplicationDbContext context,ITeamRepository teamRepository,
            IPlayerRepository playerRepository,IPositionRepository positionRepository, ICountryRepository countryRepository)
        {
            _teamRepository = teamRepository;
            _playerRepository = playerRepository;
            _countryRepository = countryRepository;
            _positionRepository = positionRepository;
        }

        public IActionResult Teams()
        {
            var wholePlayers = _playerRepository.PlayerstoTeam();
            return View(wholePlayers);
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Teams = _teamRepository.GetAll();
            ViewBag.Positions = _positionRepository.GetAll();
            ViewBag.Countries = _countryRepository.GetAll();
            return View();
        }
        [HttpPost, ActionName("Create")]
        public IActionResult CreatePost(Player model)
        {
            if (ModelState.IsValid)
            {
                _playerRepository.Add(model);
                return RedirectToAction("Teams");
            }
            return View("Create");
        }

        [HttpGet]
        public IActionResult Edit(int ID)
        {
            var player = _playerRepository.GetById(ID);
                if (player == null)
            {
                return NotFound();
            }
            ViewBag.Teams = _teamRepository.GetAll();
            ViewBag.Countries = _countryRepository.GetAll();
            ViewBag.Positions = _positionRepository.GetAll();
            return View(player);
        }

        [HttpPost, ActionName("Edit")]
        public IActionResult EditPost(Player model)
        {
            if (ModelState.IsValid)
            {
                _playerRepository.Update(model);
                return RedirectToAction("Teams");
            }
            return View("Edit");
        }

        [HttpGet]

        public IActionResult Delete(int ID)
        {
            var player = _playerRepository.GetById(ID);
            if (player == null)
            {
                return NotFound();
            }
            return View(player);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(Player model)
        {
            if (ModelState.IsValid)
            {
                _playerRepository.Delete(model);
                return RedirectToAction("Teams");
            }
            return View("Delete");
        }

    }
}
