﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WordleGame.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordleController : ControllerBase
    {
        
        private static readonly string[] wordList = new[]
        {
            "football;", "rugby", "tennis", "hockey", "swimming", "basketball", "volleyball", "netball", "baseball", "wrestling", "running", "golf", "badminton"
        };

        [HttpGet]
        [Route("generateWord")]
        public IActionResult GenerateWord()
        {
            // Instantiate random number generator using system-supplied value as seed.
            var random = new Random();
            // Generate random indexes for types of sports
            var randomIndex = random.Next(wordList.Length);
            var randomWord = wordList[randomIndex];
            Console.WriteLine($"Generated word: {randomWord}");

            return Ok(randomWord);
        }

        [HttpPost]
        [Route("checkWord")]
        public IActionResult CheckWord([FromBody] string word)
        {
            if (string.IsNullOrWhiteSpace(word))
                return BadRequest("Invalid input: word cannot be empty.");

            var lowerWord = word.ToLower();

            if (!wordList.Contains(lowerWord))
                return BadRequest($"{word} is an invalid word: {word} is not in the word list.");

            return Ok($"{word} is a valid word!");
        }
    }
}
