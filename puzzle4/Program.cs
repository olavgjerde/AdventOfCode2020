﻿using System;
using System.IO;
using System.Text.RegularExpressions;

var passports = File.ReadAllText("./input.txt").Split("\n\n");
const int totalFieldsRequired = 7;

// Some lengthy regex here...
var fieldCheckRulePartOne = new Regex(@"byr:|iyr:|eyr:|hgt:|hcl:|ecl:|pid:");
var fieldCheckRulePartTwo = new Regex(@"\bbyr:(?:19[2-9][0-9]|200[0-2])\b|\biyr:(?:201[0-9]|2020)\b|\beyr:(?:202[0-9]|2030)\b|\bhgt:(?:1[5-8][0-9]cm|19[0-3]cm|59in|6[0-9]in|7[0-6]in)\b|\bhcl:#[0-9a-f]{6}\b|\becl:(?:amb|blu|brn|gry|grn|hzl|oth)\b|\bpid:[0-9]{9}\b");

var validPassportsRuleOne = 0;
var validPassportsRuleTwo = 0;

foreach (var passport in passports)
{
    if (fieldCheckRulePartOne.Matches(passport).Count == totalFieldsRequired) validPassportsRuleOne++;
    if (fieldCheckRulePartTwo.Matches(passport).Count == totalFieldsRequired) validPassportsRuleTwo++;
}

Console.WriteLine($"Result part one: {validPassportsRuleOne}");
Console.WriteLine($"Result part two: {validPassportsRuleTwo}");
