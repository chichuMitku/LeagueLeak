﻿using LeagueLeak.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper.QueryableExtensions;
using LeagueLeak.Web.Models.Players;

namespace LeagueLeak.Web.Controllers
{
    public class PlayersController : BaseController
    {
        public PlayersController(IApplicationData data)
            :base(data)
        {
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Details(string name)
        {
            var player = this.Data.Players.All().Where(a => a.Name == name).Project().To<PlayerDetailsViewModel>().FirstOrDefault();

            if (player != null && ModelState.IsValid)
            {
                var skillScore = Math.Round((((double)player.Kills + (double)player.Assists / 3) / ((double)player.Deaths)) * 1000, 0);
                player.SkillScore = skillScore;
                return View(player);
            }

            return View("Home/Error");
        }

        [HttpGet]
        public ActionResult Leaderboards()
        {
            var players = this.Data.Players.All().OrderByDescending(p => p.Rating).Take(10).Project().To<LeaderboardsViewModel>().ToList();
            foreach (var player in players)
            {
                player.SkillScore = Math.Round((((double)player.Kills + (double)player.Assists / 3) / ((double)player.Deaths)) * 1000, 0);
            }

            return View(players);
        }
    }
}