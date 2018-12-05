﻿using System;
using AdventOfCode2018.Day1;
using AdventOfCode2018.Day2;
using AdventOfCode2018.Day3;
using AdventOfCode2018.Day4;

namespace AdventOfCode2018.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Day1();
            Day2();
            Day3();
            Day4();

            Console.ReadKey();
        }

        private static void Day4()
        {
            var input = @"[1518-03-31 00:26] falls asleep
[1518-04-03 00:38] wakes up
[1518-11-21 00:14] falls asleep
[1518-07-21 00:34] wakes up
[1518-04-02 00:20] falls asleep
[1518-08-26 00:14] wakes up
[1518-05-22 00:45] wakes up
[1518-08-18 00:57] wakes up
[1518-05-20 00:02] falls asleep
[1518-07-06 00:57] falls asleep
[1518-07-04 00:49] falls asleep
[1518-10-23 23:49] Guard #659 begins shift
[1518-08-06 00:07] falls asleep
[1518-06-24 00:58] wakes up
[1518-04-27 00:13] falls asleep
[1518-06-08 00:01] Guard #179 begins shift
[1518-06-03 00:00] Guard #659 begins shift
[1518-10-03 00:35] wakes up
[1518-04-30 00:20] wakes up
[1518-10-15 23:59] Guard #1699 begins shift
[1518-06-07 00:39] wakes up
[1518-09-25 00:10] falls asleep
[1518-09-27 00:30] falls asleep
[1518-11-03 00:36] falls asleep
[1518-06-26 00:55] wakes up
[1518-04-14 00:57] wakes up
[1518-08-07 00:45] falls asleep
[1518-06-02 00:56] wakes up
[1518-05-13 00:02] Guard #223 begins shift
[1518-04-20 00:45] falls asleep
[1518-11-14 23:59] Guard #1069 begins shift
[1518-09-17 00:58] wakes up
[1518-04-07 00:34] wakes up
[1518-09-27 00:00] Guard #419 begins shift
[1518-03-21 00:59] wakes up
[1518-07-26 00:01] Guard #457 begins shift
[1518-08-18 00:04] Guard #659 begins shift
[1518-04-20 00:01] Guard #659 begins shift
[1518-04-17 23:57] Guard #3547 begins shift
[1518-07-10 23:59] Guard #2753 begins shift
[1518-06-28 00:59] wakes up
[1518-10-26 00:01] Guard #3547 begins shift
[1518-04-15 00:49] wakes up
[1518-09-14 00:04] Guard #179 begins shift
[1518-07-21 00:02] falls asleep
[1518-07-23 00:38] falls asleep
[1518-04-04 23:59] Guard #223 begins shift
[1518-09-15 00:12] falls asleep
[1518-06-01 00:32] wakes up
[1518-08-15 00:22] falls asleep
[1518-10-05 00:34] wakes up
[1518-10-01 00:58] wakes up
[1518-05-05 00:07] falls asleep
[1518-10-23 00:34] wakes up
[1518-10-08 00:39] falls asleep
[1518-08-27 00:14] falls asleep
[1518-05-17 00:53] wakes up
[1518-08-08 00:39] falls asleep
[1518-07-28 00:03] falls asleep
[1518-05-03 00:08] falls asleep
[1518-10-12 00:52] falls asleep
[1518-04-20 00:58] wakes up
[1518-04-27 00:20] wakes up
[1518-05-14 23:58] Guard #1933 begins shift
[1518-07-12 23:59] Guard #2953 begins shift
[1518-10-12 00:00] Guard #223 begins shift
[1518-10-21 00:38] falls asleep
[1518-04-12 00:40] falls asleep
[1518-04-05 00:58] wakes up
[1518-08-16 00:34] falls asleep
[1518-07-30 23:58] Guard #419 begins shift
[1518-10-17 00:55] wakes up
[1518-08-06 23:59] Guard #409 begins shift
[1518-06-17 00:47] falls asleep
[1518-06-29 00:46] falls asleep
[1518-09-30 00:58] wakes up
[1518-06-29 00:53] wakes up
[1518-03-30 00:03] Guard #457 begins shift
[1518-11-07 00:22] falls asleep
[1518-05-04 23:56] Guard #2953 begins shift
[1518-09-23 00:19] wakes up
[1518-10-12 00:16] falls asleep
[1518-08-08 00:00] Guard #659 begins shift
[1518-11-15 00:31] wakes up
[1518-08-16 00:58] wakes up
[1518-08-18 23:59] Guard #3347 begins shift
[1518-07-06 23:58] Guard #2039 begins shift
[1518-10-15 00:52] falls asleep
[1518-09-18 00:36] wakes up
[1518-06-17 23:57] Guard #409 begins shift
[1518-09-19 23:56] Guard #647 begins shift
[1518-10-10 00:30] wakes up
[1518-11-18 23:58] Guard #2953 begins shift
[1518-10-27 00:19] falls asleep
[1518-08-05 00:51] wakes up
[1518-07-15 23:58] Guard #1699 begins shift
[1518-10-14 00:02] Guard #647 begins shift
[1518-06-04 00:00] Guard #1153 begins shift
[1518-04-16 00:00] Guard #1933 begins shift
[1518-06-25 00:28] falls asleep
[1518-05-13 23:57] Guard #419 begins shift
[1518-07-09 23:58] Guard #503 begins shift
[1518-05-08 00:16] falls asleep
[1518-08-12 00:10] falls asleep
[1518-09-16 00:47] falls asleep
[1518-07-06 00:04] Guard #3547 begins shift
[1518-06-08 00:22] falls asleep
[1518-07-09 00:02] Guard #2953 begins shift
[1518-08-22 23:58] Guard #179 begins shift
[1518-05-11 00:51] wakes up
[1518-06-05 00:59] wakes up
[1518-10-03 00:25] wakes up
[1518-05-05 00:17] wakes up
[1518-11-10 23:58] Guard #457 begins shift
[1518-09-17 00:04] Guard #409 begins shift
[1518-08-17 00:02] falls asleep
[1518-08-13 00:32] falls asleep
[1518-09-02 00:00] Guard #419 begins shift
[1518-07-24 00:48] falls asleep
[1518-04-10 00:32] wakes up
[1518-04-20 00:42] wakes up
[1518-03-24 00:03] Guard #223 begins shift
[1518-11-21 23:50] Guard #2953 begins shift
[1518-09-20 00:57] wakes up
[1518-08-11 00:42] wakes up
[1518-08-08 00:49] wakes up
[1518-06-12 23:47] Guard #647 begins shift
[1518-03-26 00:58] wakes up
[1518-11-02 00:55] wakes up
[1518-10-22 00:03] Guard #1069 begins shift
[1518-07-14 23:59] Guard #401 begins shift
[1518-04-30 00:15] falls asleep
[1518-06-21 00:37] wakes up
[1518-07-15 00:54] wakes up
[1518-05-14 00:50] wakes up
[1518-09-16 00:53] wakes up
[1518-09-05 00:01] Guard #2039 begins shift
[1518-05-25 23:59] Guard #2753 begins shift
[1518-10-28 00:30] falls asleep
[1518-10-06 23:56] Guard #2953 begins shift
[1518-08-21 00:01] Guard #419 begins shift
[1518-04-25 23:59] Guard #2693 begins shift
[1518-11-16 00:55] wakes up
[1518-05-12 00:47] wakes up
[1518-07-03 00:39] falls asleep
[1518-05-10 00:54] falls asleep
[1518-03-30 00:57] wakes up
[1518-11-20 00:56] falls asleep
[1518-07-23 00:11] wakes up
[1518-10-12 00:59] wakes up
[1518-04-25 00:03] Guard #1153 begins shift
[1518-11-05 23:57] Guard #179 begins shift
[1518-03-30 23:53] Guard #691 begins shift
[1518-05-15 23:57] Guard #223 begins shift
[1518-08-23 00:31] falls asleep
[1518-08-22 00:54] wakes up
[1518-09-07 00:53] falls asleep
[1518-11-20 00:00] Guard #1699 begins shift
[1518-08-13 00:35] wakes up
[1518-09-15 00:59] wakes up
[1518-10-27 00:42] wakes up
[1518-05-27 00:22] wakes up
[1518-08-18 00:25] wakes up
[1518-08-04 00:28] falls asleep
[1518-09-24 00:57] wakes up
[1518-07-24 00:57] wakes up
[1518-07-16 00:51] wakes up
[1518-05-25 00:37] falls asleep
[1518-06-01 00:14] falls asleep
[1518-10-05 00:20] falls asleep
[1518-04-15 00:11] wakes up
[1518-05-23 23:56] Guard #2953 begins shift
[1518-11-22 00:04] falls asleep
[1518-09-11 00:59] wakes up
[1518-10-23 00:44] wakes up
[1518-11-13 00:41] falls asleep
[1518-10-06 00:04] Guard #2753 begins shift
[1518-04-25 00:48] wakes up
[1518-05-01 00:13] falls asleep
[1518-06-27 00:49] wakes up
[1518-09-29 00:18] falls asleep
[1518-10-02 23:56] Guard #691 begins shift
[1518-03-28 00:42] wakes up
[1518-05-30 00:23] falls asleep
[1518-10-21 00:24] falls asleep
[1518-11-03 00:28] wakes up
[1518-10-18 00:20] falls asleep
[1518-10-11 00:45] falls asleep
[1518-10-02 00:23] falls asleep
[1518-11-02 00:42] wakes up
[1518-11-03 00:01] Guard #457 begins shift
[1518-08-05 00:47] falls asleep
[1518-09-05 00:23] wakes up
[1518-08-28 00:00] Guard #1069 begins shift
[1518-09-17 00:44] wakes up
[1518-06-16 23:59] Guard #691 begins shift
[1518-08-05 00:02] Guard #1069 begins shift
[1518-04-12 00:01] Guard #691 begins shift
[1518-11-06 00:43] wakes up
[1518-06-09 00:28] falls asleep
[1518-05-14 00:26] falls asleep
[1518-09-11 00:04] Guard #2693 begins shift
[1518-09-06 00:33] falls asleep
[1518-09-29 00:44] wakes up
[1518-06-04 23:49] Guard #1933 begins shift
[1518-03-25 00:02] Guard #1153 begins shift
[1518-10-25 00:59] wakes up
[1518-08-29 00:37] falls asleep
[1518-09-30 00:40] wakes up
[1518-05-17 23:50] Guard #223 begins shift
[1518-05-19 23:46] Guard #1933 begins shift
[1518-07-18 00:40] falls asleep
[1518-09-23 00:33] falls asleep
[1518-09-08 00:17] falls asleep
[1518-11-19 00:12] falls asleep
[1518-03-31 00:05] falls asleep
[1518-08-24 00:31] wakes up
[1518-05-11 00:10] falls asleep
[1518-07-29 00:14] wakes up
[1518-07-10 00:43] wakes up
[1518-08-18 00:15] falls asleep
[1518-04-10 00:50] wakes up
[1518-05-26 00:23] wakes up
[1518-09-03 00:04] Guard #223 begins shift
[1518-04-11 00:06] falls asleep
[1518-07-29 00:12] falls asleep
[1518-10-04 00:28] wakes up
[1518-08-21 00:49] falls asleep
[1518-10-15 00:43] wakes up
[1518-03-26 00:47] wakes up
[1518-04-08 00:58] wakes up
[1518-07-27 00:52] wakes up
[1518-05-30 23:56] Guard #179 begins shift
[1518-09-22 00:02] Guard #2693 begins shift
[1518-10-14 00:46] falls asleep
[1518-11-05 00:21] falls asleep
[1518-05-16 23:59] Guard #1069 begins shift
[1518-05-17 00:27] falls asleep
[1518-09-28 00:52] falls asleep
[1518-07-22 00:20] falls asleep
[1518-06-13 00:02] falls asleep
[1518-05-28 00:27] falls asleep
[1518-05-07 00:43] wakes up
[1518-05-20 00:44] falls asleep
[1518-05-20 23:57] Guard #691 begins shift
[1518-05-02 00:51] wakes up
[1518-10-01 00:53] falls asleep
[1518-11-04 00:26] falls asleep
[1518-04-01 00:55] wakes up
[1518-04-07 00:25] falls asleep
[1518-03-26 00:03] Guard #1933 begins shift
[1518-07-16 00:28] falls asleep
[1518-07-05 00:03] Guard #163 begins shift
[1518-04-24 00:49] wakes up
[1518-03-30 00:23] falls asleep
[1518-04-27 00:04] Guard #647 begins shift
[1518-07-31 00:36] falls asleep
[1518-10-06 00:42] wakes up
[1518-06-10 00:51] wakes up
[1518-08-10 00:22] falls asleep
[1518-04-22 00:00] Guard #647 begins shift
[1518-04-16 00:43] wakes up
[1518-05-27 00:13] falls asleep
[1518-07-18 23:58] Guard #2039 begins shift
[1518-05-11 00:37] falls asleep
[1518-09-28 00:34] wakes up
[1518-08-26 00:49] wakes up
[1518-04-26 00:24] falls asleep
[1518-07-04 00:50] wakes up
[1518-05-15 00:57] wakes up
[1518-11-01 00:39] wakes up
[1518-09-28 00:55] wakes up
[1518-06-25 00:17] wakes up
[1518-06-25 00:00] Guard #163 begins shift
[1518-07-20 00:59] wakes up
[1518-10-06 00:36] falls asleep
[1518-10-02 00:02] Guard #659 begins shift
[1518-09-23 23:50] Guard #503 begins shift
[1518-03-20 00:00] Guard #457 begins shift
[1518-04-24 00:19] falls asleep
[1518-05-08 00:51] wakes up
[1518-07-16 23:58] Guard #2753 begins shift
[1518-11-01 00:49] wakes up
[1518-11-08 00:00] Guard #1699 begins shift
[1518-06-12 00:15] falls asleep
[1518-10-18 23:59] Guard #647 begins shift
[1518-08-02 00:53] wakes up
[1518-05-23 00:29] wakes up
[1518-03-25 00:09] falls asleep
[1518-10-21 00:25] wakes up
[1518-03-22 00:00] Guard #503 begins shift
[1518-05-19 00:05] falls asleep
[1518-06-09 00:50] wakes up
[1518-09-26 00:32] wakes up
[1518-03-24 00:34] falls asleep
[1518-08-25 00:01] Guard #1069 begins shift
[1518-04-26 00:44] wakes up
[1518-05-22 00:00] Guard #419 begins shift
[1518-11-20 00:57] wakes up
[1518-05-02 00:50] falls asleep
[1518-11-17 00:41] wakes up
[1518-06-07 00:21] falls asleep
[1518-06-19 00:24] falls asleep
[1518-08-08 23:57] Guard #1069 begins shift
[1518-11-16 00:36] falls asleep
[1518-09-03 00:45] wakes up
[1518-07-15 00:44] wakes up
[1518-07-11 00:25] wakes up
[1518-09-18 23:51] Guard #2953 begins shift
[1518-10-03 23:49] Guard #1933 begins shift
[1518-10-30 00:31] falls asleep
[1518-09-18 00:33] falls asleep
[1518-08-10 00:39] wakes up
[1518-07-30 00:56] wakes up
[1518-09-25 23:51] Guard #659 begins shift
[1518-11-19 00:59] wakes up
[1518-05-21 00:55] wakes up
[1518-10-15 00:53] wakes up
[1518-09-22 00:20] falls asleep
[1518-04-21 00:44] falls asleep
[1518-11-12 00:45] wakes up
[1518-05-23 00:28] falls asleep
[1518-05-05 23:59] Guard #2753 begins shift
[1518-10-15 00:39] falls asleep
[1518-09-09 00:51] wakes up
[1518-06-11 23:57] Guard #1069 begins shift
[1518-06-01 00:47] wakes up
[1518-09-28 00:43] falls asleep
[1518-04-27 00:33] falls asleep
[1518-08-08 00:31] wakes up
[1518-09-09 23:59] Guard #691 begins shift
[1518-10-17 00:43] wakes up
[1518-10-23 00:43] falls asleep
[1518-07-03 00:50] wakes up
[1518-07-06 00:33] wakes up
[1518-06-25 00:41] wakes up
[1518-06-13 00:44] wakes up
[1518-10-28 00:35] wakes up
[1518-08-16 00:01] falls asleep
[1518-03-22 00:17] falls asleep
[1518-07-06 00:47] wakes up
[1518-09-13 00:01] Guard #659 begins shift
[1518-06-14 00:01] Guard #2953 begins shift
[1518-07-19 00:57] wakes up
[1518-09-15 23:58] Guard #223 begins shift
[1518-10-19 00:06] falls asleep
[1518-09-21 00:49] wakes up
[1518-08-26 00:03] falls asleep
[1518-07-08 00:13] falls asleep
[1518-06-08 23:56] Guard #1069 begins shift
[1518-07-27 00:37] falls asleep
[1518-07-06 00:17] falls asleep
[1518-04-23 00:25] wakes up
[1518-06-30 00:33] wakes up
[1518-04-08 00:46] falls asleep
[1518-04-02 00:57] wakes up
[1518-11-22 00:51] falls asleep
[1518-06-10 23:58] Guard #1933 begins shift
[1518-09-15 00:49] falls asleep
[1518-10-10 00:42] falls asleep
[1518-04-14 00:49] falls asleep
[1518-09-03 23:59] Guard #2039 begins shift
[1518-06-17 00:34] falls asleep
[1518-07-20 00:00] Guard #2953 begins shift
[1518-07-31 00:41] wakes up
[1518-10-25 00:45] falls asleep
[1518-03-24 00:30] wakes up
[1518-04-10 00:15] falls asleep
[1518-06-30 00:36] falls asleep
[1518-07-03 00:01] Guard #2953 begins shift
[1518-05-21 00:08] falls asleep
[1518-09-04 00:29] wakes up
[1518-10-03 00:10] falls asleep
[1518-06-04 00:56] wakes up
[1518-09-04 00:23] falls asleep
[1518-05-09 23:59] Guard #179 begins shift
[1518-10-20 00:42] wakes up
[1518-07-22 00:04] Guard #1699 begins shift
[1518-06-23 00:49] wakes up
[1518-04-29 00:58] wakes up
[1518-05-02 00:03] Guard #647 begins shift
[1518-08-03 00:07] falls asleep
[1518-09-24 00:22] falls asleep
[1518-04-13 00:05] falls asleep
[1518-09-03 00:41] falls asleep
[1518-09-26 00:00] falls asleep
[1518-05-10 00:45] wakes up
[1518-04-18 00:39] wakes up
[1518-11-15 00:41] falls asleep
[1518-05-25 00:04] Guard #409 begins shift
[1518-07-07 00:35] falls asleep
[1518-04-28 00:53] wakes up
[1518-11-21 00:54] wakes up
[1518-10-10 00:24] falls asleep
[1518-07-17 00:40] falls asleep
[1518-10-26 00:18] falls asleep
[1518-07-14 00:58] wakes up
[1518-06-27 00:11] falls asleep
[1518-09-17 00:51] falls asleep
[1518-07-25 00:51] wakes up
[1518-07-02 00:06] falls asleep
[1518-03-29 00:01] falls asleep
[1518-11-09 00:57] wakes up
[1518-08-06 00:32] wakes up
[1518-10-02 00:25] wakes up
[1518-08-17 00:39] wakes up
[1518-06-21 00:21] falls asleep
[1518-11-17 23:53] Guard #3547 begins shift
[1518-04-17 00:38] wakes up
[1518-04-12 00:50] wakes up
[1518-11-23 00:49] wakes up
[1518-10-05 00:07] falls asleep
[1518-03-20 00:14] falls asleep
[1518-05-28 00:00] Guard #1933 begins shift
[1518-05-29 00:04] falls asleep
[1518-10-28 00:43] falls asleep
[1518-03-26 00:21] falls asleep
[1518-11-21 00:50] falls asleep
[1518-10-04 00:05] falls asleep
[1518-05-07 00:19] falls asleep
[1518-10-10 00:50] falls asleep
[1518-03-31 00:45] wakes up
[1518-10-06 00:30] falls asleep
[1518-11-04 00:00] Guard #179 begins shift
[1518-05-28 00:56] falls asleep
[1518-05-18 00:31] falls asleep
[1518-09-08 00:34] falls asleep
[1518-09-13 00:17] falls asleep
[1518-03-19 00:37] falls asleep
[1518-06-30 00:58] wakes up
[1518-03-23 00:23] falls asleep
[1518-07-30 00:26] falls asleep
[1518-04-09 00:47] wakes up
[1518-07-26 00:11] falls asleep
[1518-07-02 00:04] Guard #1699 begins shift
[1518-09-14 00:51] wakes up
[1518-04-29 00:46] falls asleep
[1518-04-19 00:58] wakes up
[1518-04-18 00:57] wakes up
[1518-07-14 00:10] falls asleep
[1518-05-28 00:33] wakes up
[1518-05-10 00:27] falls asleep
[1518-09-28 00:18] falls asleep
[1518-08-13 00:01] Guard #647 begins shift
[1518-09-06 00:51] wakes up
[1518-11-17 00:02] Guard #2953 begins shift
[1518-04-09 00:31] falls asleep
[1518-07-08 00:02] Guard #659 begins shift
[1518-09-22 00:58] wakes up
[1518-07-28 00:34] wakes up
[1518-11-17 00:22] falls asleep
[1518-04-03 00:00] Guard #659 begins shift
[1518-08-14 00:51] wakes up
[1518-05-12 00:04] Guard #2039 begins shift
[1518-09-16 00:39] wakes up
[1518-06-02 00:19] falls asleep
[1518-08-19 23:58] Guard #3547 begins shift
[1518-04-21 00:03] Guard #179 begins shift
[1518-04-17 00:13] falls asleep
[1518-06-26 23:56] Guard #1933 begins shift
[1518-03-27 23:58] Guard #2693 begins shift
[1518-04-01 00:11] falls asleep
[1518-08-30 00:04] Guard #2753 begins shift
[1518-11-02 00:16] wakes up
[1518-10-08 00:01] Guard #2039 begins shift
[1518-04-02 00:00] Guard #457 begins shift
[1518-10-04 00:55] wakes up
[1518-05-28 00:58] wakes up
[1518-09-13 00:55] wakes up
[1518-08-23 00:38] wakes up
[1518-04-18 00:25] wakes up
[1518-08-15 23:51] Guard #401 begins shift
[1518-07-28 00:48] wakes up
[1518-08-27 00:02] Guard #691 begins shift
[1518-03-28 00:59] wakes up
[1518-08-29 00:04] Guard #1153 begins shift
[1518-07-31 23:58] Guard #3347 begins shift
[1518-11-01 23:56] Guard #409 begins shift
[1518-08-12 00:32] falls asleep
[1518-06-05 00:05] falls asleep
[1518-09-16 00:21] falls asleep
[1518-04-04 00:03] Guard #1637 begins shift
[1518-04-12 00:26] wakes up
[1518-06-15 00:23] wakes up
[1518-05-07 00:01] Guard #1699 begins shift
[1518-05-06 00:43] falls asleep
[1518-09-27 00:46] wakes up
[1518-07-22 00:58] wakes up
[1518-09-03 00:36] falls asleep
[1518-04-16 23:58] Guard #419 begins shift
[1518-11-11 00:20] falls asleep
[1518-04-20 00:11] falls asleep
[1518-06-29 00:27] falls asleep
[1518-10-09 00:59] wakes up
[1518-07-15 00:31] falls asleep
[1518-11-10 00:00] Guard #419 begins shift
[1518-09-11 00:40] falls asleep
[1518-03-24 00:59] wakes up
[1518-06-01 00:36] falls asleep
[1518-05-31 00:33] falls asleep
[1518-05-16 00:47] falls asleep
[1518-10-12 00:40] falls asleep
[1518-10-23 00:29] falls asleep
[1518-11-22 00:37] wakes up
[1518-07-09 00:54] wakes up
[1518-07-05 00:42] falls asleep
[1518-07-29 00:00] Guard #2953 begins shift
[1518-09-30 00:46] falls asleep
[1518-08-10 00:03] Guard #2039 begins shift
[1518-03-27 00:08] falls asleep
[1518-03-24 00:24] falls asleep
[1518-05-09 00:25] falls asleep
[1518-06-14 00:57] wakes up
[1518-10-29 23:56] Guard #1699 begins shift
[1518-05-02 23:56] Guard #401 begins shift
[1518-11-20 00:27] falls asleep
[1518-07-20 23:51] Guard #419 begins shift
[1518-04-06 00:59] wakes up
[1518-10-01 00:04] Guard #2753 begins shift
[1518-10-01 00:46] wakes up
[1518-07-14 00:02] Guard #1069 begins shift
[1518-04-16 00:25] falls asleep
[1518-10-10 23:56] Guard #691 begins shift
[1518-08-20 00:58] wakes up
[1518-09-21 00:11] falls asleep
[1518-04-03 00:26] falls asleep
[1518-06-20 00:54] wakes up
[1518-11-01 00:04] Guard #1069 begins shift
[1518-05-28 23:54] Guard #2039 begins shift
[1518-03-22 00:36] wakes up
[1518-10-26 00:40] wakes up
[1518-10-11 00:51] wakes up
[1518-04-27 00:58] wakes up
[1518-04-10 00:18] wakes up
[1518-04-22 00:54] wakes up
[1518-09-12 00:48] wakes up
[1518-04-28 00:23] falls asleep
[1518-11-21 00:38] wakes up
[1518-05-20 00:40] wakes up
[1518-10-14 00:51] wakes up
[1518-06-27 00:46] falls asleep
[1518-09-18 00:44] falls asleep
[1518-10-09 23:56] Guard #419 begins shift
[1518-04-27 00:18] falls asleep
[1518-10-20 00:59] wakes up
[1518-05-17 00:47] falls asleep
[1518-04-18 00:08] falls asleep
[1518-07-29 00:58] wakes up
[1518-06-10 00:03] Guard #1699 begins shift
[1518-09-06 00:15] falls asleep
[1518-10-23 00:49] wakes up
[1518-11-12 00:33] falls asleep
[1518-10-12 23:51] Guard #163 begins shift
[1518-06-04 00:33] falls asleep
[1518-08-24 00:43] falls asleep
[1518-07-17 23:56] Guard #1699 begins shift
[1518-10-02 00:44] wakes up
[1518-09-12 00:01] Guard #401 begins shift
[1518-08-12 00:28] wakes up
[1518-07-18 00:27] wakes up
[1518-03-27 00:01] Guard #647 begins shift
[1518-05-27 00:57] wakes up
[1518-03-20 00:26] wakes up
[1518-04-23 00:01] Guard #691 begins shift
[1518-09-24 23:59] Guard #1153 begins shift
[1518-06-02 00:34] wakes up
[1518-09-09 00:02] Guard #503 begins shift
[1518-04-11 00:03] Guard #457 begins shift
[1518-05-30 00:38] wakes up
[1518-04-05 00:43] falls asleep
[1518-06-17 00:59] wakes up
[1518-05-01 00:04] Guard #659 begins shift
[1518-06-11 00:46] wakes up
[1518-09-12 00:08] falls asleep
[1518-08-18 00:41] falls asleep
[1518-07-19 00:36] wakes up
[1518-09-02 00:39] wakes up
[1518-05-27 00:50] falls asleep
[1518-10-13 00:54] wakes up
[1518-07-09 00:17] falls asleep
[1518-07-05 00:26] falls asleep
[1518-08-10 23:50] Guard #659 begins shift
[1518-04-27 00:14] wakes up
[1518-04-29 00:42] wakes up
[1518-11-09 00:50] falls asleep
[1518-05-24 00:39] falls asleep
[1518-09-15 00:45] wakes up
[1518-07-06 00:58] wakes up
[1518-09-09 00:56] falls asleep
[1518-09-20 23:59] Guard #2039 begins shift
[1518-06-24 00:47] falls asleep
[1518-07-03 00:56] falls asleep
[1518-06-01 23:59] Guard #223 begins shift
[1518-04-13 00:35] wakes up
[1518-05-07 23:57] Guard #457 begins shift
[1518-11-08 00:43] wakes up
[1518-07-27 00:03] Guard #1153 begins shift
[1518-08-07 00:53] wakes up
[1518-09-20 00:33] wakes up
[1518-11-14 00:44] wakes up
[1518-05-31 00:44] wakes up
[1518-06-22 00:44] wakes up
[1518-05-15 00:15] falls asleep
[1518-09-30 00:00] Guard #2693 begins shift
[1518-11-22 00:53] wakes up
[1518-10-20 23:58] Guard #163 begins shift
[1518-06-15 23:56] Guard #1699 begins shift
[1518-07-08 00:34] wakes up
[1518-11-02 00:30] falls asleep
[1518-06-03 00:57] wakes up
[1518-06-30 00:15] falls asleep
[1518-04-12 00:54] falls asleep
[1518-06-19 00:00] Guard #1933 begins shift
[1518-11-11 23:57] Guard #179 begins shift
[1518-04-08 00:02] Guard #503 begins shift
[1518-04-09 23:57] Guard #163 begins shift
[1518-07-21 00:50] falls asleep
[1518-11-12 00:10] falls asleep
[1518-10-10 00:54] wakes up
[1518-10-27 23:59] Guard #1069 begins shift
[1518-08-03 00:59] wakes up
[1518-07-23 23:58] Guard #223 begins shift
[1518-08-21 00:59] wakes up
[1518-05-09 00:43] wakes up
[1518-06-26 00:16] falls asleep
[1518-08-21 00:50] wakes up
[1518-10-16 00:35] falls asleep
[1518-09-28 00:49] wakes up
[1518-05-30 00:00] Guard #419 begins shift
[1518-11-12 00:13] wakes up
[1518-06-07 00:53] falls asleep
[1518-07-18 00:58] wakes up
[1518-07-10 00:54] falls asleep
[1518-09-07 00:55] wakes up
[1518-04-19 00:57] falls asleep
[1518-05-05 00:52] wakes up
[1518-06-18 00:55] wakes up
[1518-10-18 00:00] Guard #1933 begins shift
[1518-09-11 00:23] wakes up
[1518-06-22 23:58] Guard #2953 begins shift
[1518-06-29 00:42] wakes up
[1518-04-10 00:25] falls asleep
[1518-11-13 00:00] Guard #2753 begins shift
[1518-03-28 23:50] Guard #419 begins shift
[1518-08-25 00:39] wakes up
[1518-08-21 00:57] falls asleep
[1518-08-29 00:49] wakes up
[1518-10-12 00:48] wakes up
[1518-05-11 00:23] wakes up
[1518-06-23 23:56] Guard #1153 begins shift
[1518-05-19 00:50] wakes up
[1518-11-13 00:55] wakes up
[1518-07-05 00:28] wakes up
[1518-10-18 00:53] wakes up
[1518-07-19 00:54] falls asleep
[1518-06-07 00:42] falls asleep
[1518-10-22 00:47] wakes up
[1518-05-03 00:54] falls asleep
[1518-09-05 00:17] falls asleep
[1518-10-21 00:42] wakes up
[1518-11-01 00:13] falls asleep
[1518-05-10 23:58] Guard #223 begins shift
[1518-07-01 00:48] wakes up
[1518-03-23 00:55] wakes up
[1518-08-16 23:54] Guard #2039 begins shift
[1518-04-29 00:16] falls asleep
[1518-07-01 00:20] falls asleep
[1518-05-03 00:57] wakes up
[1518-06-28 00:03] Guard #179 begins shift
[1518-04-25 00:21] falls asleep
[1518-05-13 00:38] wakes up
[1518-05-18 23:52] Guard #1699 begins shift
[1518-04-14 23:59] Guard #2039 begins shift
[1518-06-28 00:51] falls asleep
[1518-07-20 00:20] falls asleep
[1518-06-02 00:42] falls asleep
[1518-09-08 00:04] Guard #1699 begins shift
[1518-05-18 00:01] falls asleep
[1518-11-10 00:48] wakes up
[1518-10-08 23:56] Guard #409 begins shift
[1518-10-19 00:53] wakes up
[1518-04-12 00:55] wakes up
[1518-06-23 00:14] falls asleep
[1518-09-02 00:17] falls asleep
[1518-09-20 00:20] falls asleep
[1518-11-18 00:03] falls asleep
[1518-09-23 00:12] falls asleep
[1518-06-20 00:08] falls asleep
[1518-09-29 00:05] falls asleep
[1518-08-20 00:16] falls asleep
[1518-10-05 00:16] wakes up
[1518-09-04 00:55] wakes up
[1518-10-05 00:00] Guard #3547 begins shift
[1518-10-29 00:11] falls asleep
[1518-09-03 00:37] wakes up
[1518-06-07 00:01] Guard #457 begins shift
[1518-10-16 00:54] wakes up
[1518-05-20 00:34] falls asleep
[1518-06-01 00:01] Guard #1069 begins shift
[1518-08-11 00:04] falls asleep
[1518-03-27 00:12] wakes up
[1518-11-07 00:55] wakes up
[1518-08-22 00:00] falls asleep
[1518-08-30 00:51] wakes up
[1518-07-11 00:21] falls asleep
[1518-07-21 00:53] wakes up
[1518-10-02 00:30] falls asleep
[1518-10-06 00:31] wakes up
[1518-07-26 00:45] wakes up
[1518-11-21 00:00] Guard #2693 begins shift
[1518-03-21 00:03] Guard #691 begins shift
[1518-06-21 00:00] Guard #503 begins shift
[1518-07-10 00:08] falls asleep
[1518-07-23 00:09] falls asleep
[1518-09-05 00:29] falls asleep
[1518-09-10 00:23] falls asleep
[1518-06-20 00:04] Guard #1933 begins shift
[1518-06-30 23:59] Guard #691 begins shift
[1518-10-09 00:35] falls asleep
[1518-10-19 23:58] Guard #179 begins shift
[1518-09-06 00:18] wakes up
[1518-04-10 00:47] falls asleep
[1518-08-28 00:18] falls asleep
[1518-05-18 00:06] wakes up
[1518-11-06 00:31] wakes up
[1518-08-08 00:26] falls asleep
[1518-11-08 00:30] falls asleep
[1518-09-20 00:56] falls asleep
[1518-08-15 00:42] wakes up
[1518-09-18 00:50] wakes up
[1518-06-03 00:22] falls asleep
[1518-05-25 00:56] wakes up
[1518-06-11 00:33] falls asleep
[1518-05-16 00:59] wakes up
[1518-09-18 00:03] Guard #659 begins shift
[1518-10-30 00:48] wakes up
[1518-08-26 00:25] falls asleep
[1518-11-15 00:26] falls asleep
[1518-06-19 00:26] wakes up
[1518-10-29 00:42] wakes up
[1518-09-01 00:47] wakes up
[1518-08-25 23:48] Guard #1069 begins shift
[1518-06-22 00:32] falls asleep
[1518-08-21 23:51] Guard #1069 begins shift
[1518-10-12 00:22] wakes up
[1518-10-27 00:26] wakes up
[1518-04-28 23:58] Guard #179 begins shift
[1518-06-10 00:58] wakes up
[1518-11-06 00:18] falls asleep
[1518-07-20 00:57] falls asleep
[1518-04-01 00:35] falls asleep
[1518-08-14 00:10] falls asleep
[1518-06-06 00:52] wakes up
[1518-08-27 00:33] wakes up
[1518-07-04 00:00] Guard #691 begins shift
[1518-07-25 00:33] falls asleep
[1518-11-10 00:21] falls asleep
[1518-08-16 00:17] wakes up
[1518-11-05 00:51] wakes up
[1518-10-01 00:41] falls asleep
[1518-04-08 00:20] wakes up
[1518-08-12 00:00] Guard #223 begins shift
[1518-09-01 00:03] Guard #223 begins shift
[1518-10-28 00:54] wakes up
[1518-09-12 00:45] falls asleep
[1518-11-01 00:44] falls asleep
[1518-03-19 00:02] Guard #2953 begins shift
[1518-04-06 00:41] falls asleep
[1518-07-15 00:49] falls asleep
[1518-10-25 00:16] falls asleep
[1518-05-28 00:46] falls asleep
[1518-03-27 00:22] falls asleep
[1518-10-17 00:50] falls asleep
[1518-04-13 23:57] Guard #1153 begins shift
[1518-09-04 00:37] falls asleep
[1518-05-01 00:57] wakes up
[1518-11-13 23:57] Guard #691 begins shift
[1518-03-21 00:31] falls asleep
[1518-10-10 00:45] wakes up
[1518-04-28 00:09] falls asleep
[1518-06-07 00:57] wakes up
[1518-07-28 00:47] falls asleep
[1518-09-06 23:58] Guard #409 begins shift
[1518-06-13 00:53] wakes up
[1518-10-03 00:33] falls asleep
[1518-06-16 00:34] wakes up
[1518-03-28 00:18] falls asleep
[1518-10-07 00:26] falls asleep
[1518-10-23 00:00] Guard #1069 begins shift
[1518-06-18 00:20] falls asleep
[1518-11-09 00:04] Guard #457 begins shift
[1518-11-03 00:59] wakes up
[1518-11-09 00:25] falls asleep
[1518-04-15 00:08] falls asleep
[1518-05-03 00:35] wakes up
[1518-04-28 00:12] wakes up
[1518-04-06 00:03] Guard #179 begins shift
[1518-07-20 00:44] wakes up
[1518-09-05 00:48] wakes up
[1518-06-17 00:35] wakes up
[1518-07-24 23:57] Guard #223 begins shift
[1518-10-29 00:00] Guard #419 begins shift
[1518-03-19 00:41] wakes up
[1518-07-30 00:00] Guard #2953 begins shift
[1518-06-14 00:50] falls asleep
[1518-07-12 00:32] wakes up
[1518-06-25 23:57] Guard #1069 begins shift
[1518-06-10 00:44] falls asleep
[1518-05-17 00:32] wakes up
[1518-10-08 00:48] wakes up
[1518-11-03 00:22] falls asleep
[1518-10-24 00:02] falls asleep
[1518-10-27 00:29] falls asleep
[1518-04-01 00:23] wakes up
[1518-08-05 00:33] wakes up
[1518-08-09 00:41] wakes up
[1518-11-06 00:42] falls asleep
[1518-08-24 00:49] wakes up
[1518-09-14 23:56] Guard #1699 begins shift
[1518-07-19 00:11] falls asleep
[1518-04-15 00:37] falls asleep
[1518-09-01 00:34] falls asleep
[1518-07-29 00:22] falls asleep
[1518-11-02 00:51] falls asleep
[1518-05-02 00:22] wakes up
[1518-05-26 00:10] falls asleep
[1518-10-24 23:59] Guard #1153 begins shift
[1518-07-12 00:01] Guard #691 begins shift
[1518-08-04 00:04] Guard #691 begins shift
[1518-05-02 00:58] wakes up
[1518-11-11 00:52] wakes up
[1518-10-31 00:00] Guard #683 begins shift
[1518-06-13 00:50] falls asleep
[1518-07-05 00:53] wakes up
[1518-07-05 00:22] wakes up
[1518-10-23 00:48] falls asleep
[1518-04-22 00:52] falls asleep
[1518-09-28 00:04] Guard #647 begins shift
[1518-05-04 00:24] falls asleep
[1518-05-20 00:21] wakes up
[1518-10-15 00:01] Guard #409 begins shift
[1518-09-10 00:33] wakes up
[1518-04-28 00:01] Guard #1699 begins shift
[1518-04-11 00:50] wakes up
[1518-05-05 00:23] falls asleep
[1518-10-16 23:59] Guard #409 begins shift
[1518-11-15 00:51] wakes up
[1518-09-09 00:33] falls asleep
[1518-07-12 00:21] falls asleep
[1518-04-12 23:51] Guard #1699 begins shift
[1518-06-10 00:54] falls asleep
[1518-07-13 00:39] wakes up
[1518-09-12 00:38] wakes up
[1518-06-06 00:02] Guard #1153 begins shift
[1518-06-25 00:10] falls asleep
[1518-09-24 00:14] wakes up
[1518-10-24 00:33] wakes up
[1518-07-17 00:43] wakes up
[1518-07-23 00:03] Guard #419 begins shift
[1518-10-07 00:55] wakes up
[1518-05-04 00:04] Guard #2753 begins shift
[1518-05-22 00:06] falls asleep
[1518-10-13 00:04] falls asleep
[1518-11-23 00:02] Guard #457 begins shift
[1518-08-04 00:57] wakes up
[1518-09-30 00:33] falls asleep
[1518-11-02 00:15] falls asleep
[1518-03-28 00:56] falls asleep
[1518-10-04 00:47] falls asleep
[1518-04-30 00:03] Guard #401 begins shift
[1518-06-27 00:33] wakes up
[1518-07-10 00:56] wakes up
[1518-03-25 00:51] wakes up
[1518-10-20 00:33] falls asleep
[1518-11-20 00:51] wakes up
[1518-05-06 00:46] wakes up
[1518-07-27 23:47] Guard #3547 begins shift
[1518-08-02 00:02] Guard #419 begins shift
[1518-08-12 00:55] wakes up
[1518-09-22 23:58] Guard #419 begins shift
[1518-05-27 00:03] Guard #457 begins shift
[1518-04-08 00:19] falls asleep
[1518-07-27 00:20] falls asleep
[1518-03-31 00:22] wakes up
[1518-09-29 00:14] wakes up
[1518-06-07 00:50] wakes up
[1518-07-05 00:06] falls asleep
[1518-09-14 00:06] falls asleep
[1518-05-20 00:54] wakes up
[1518-08-15 00:51] falls asleep
[1518-04-18 00:44] falls asleep
[1518-07-27 00:24] wakes up
[1518-10-20 00:52] falls asleep
[1518-08-28 00:45] wakes up
[1518-08-02 00:15] falls asleep
[1518-04-21 00:52] wakes up
[1518-07-23 00:51] wakes up
[1518-09-19 00:02] falls asleep
[1518-10-26 23:59] Guard #179 begins shift
[1518-04-23 00:15] falls asleep
[1518-04-06 23:57] Guard #2693 begins shift
[1518-09-23 00:38] wakes up
[1518-08-05 00:28] falls asleep
[1518-09-08 00:51] wakes up
[1518-11-09 00:44] wakes up
[1518-07-03 00:59] wakes up
[1518-08-06 00:00] Guard #419 begins shift
[1518-06-16 00:29] falls asleep
[1518-09-28 23:53] Guard #401 begins shift
[1518-11-04 23:57] Guard #163 begins shift
[1518-07-31 00:19] wakes up
[1518-06-06 00:43] falls asleep
[1518-11-04 00:42] wakes up
[1518-08-02 23:59] Guard #1699 begins shift
[1518-05-10 00:56] wakes up
[1518-05-28 00:48] wakes up
[1518-08-09 00:13] falls asleep
[1518-06-22 00:04] Guard #2953 begins shift
[1518-05-08 23:59] Guard #2953 begins shift
[1518-04-01 00:03] Guard #419 begins shift
[1518-10-25 00:38] wakes up
[1518-05-02 00:13] falls asleep
[1518-05-04 00:51] wakes up
[1518-10-17 00:41] falls asleep
[1518-09-24 00:03] falls asleep
[1518-09-09 00:58] wakes up
[1518-04-12 00:12] falls asleep
[1518-06-14 23:48] Guard #2693 begins shift
[1518-03-27 00:35] wakes up
[1518-03-23 00:02] Guard #223 begins shift
[1518-06-12 00:50] wakes up
[1518-07-18 00:23] falls asleep
[1518-08-25 00:30] falls asleep
[1518-05-12 00:11] falls asleep
[1518-09-19 00:40] wakes up
[1518-08-15 00:57] wakes up
[1518-09-25 00:46] wakes up
[1518-07-07 00:41] wakes up
[1518-05-02 00:54] falls asleep
[1518-05-24 00:57] wakes up
[1518-11-16 00:00] Guard #2039 begins shift
[1518-08-24 00:23] falls asleep
[1518-07-13 00:36] falls asleep
[1518-07-02 00:42] falls asleep
[1518-04-08 23:57] Guard #2953 begins shift
[1518-06-29 23:56] Guard #3547 begins shift
[1518-03-26 00:56] falls asleep
[1518-08-15 00:01] Guard #659 begins shift
[1518-06-29 00:00] Guard #1153 begins shift
[1518-05-29 00:56] wakes up
[1518-05-13 00:07] falls asleep
[1518-04-24 00:01] Guard #419 begins shift
[1518-09-17 00:40] falls asleep
[1518-08-23 23:59] Guard #179 begins shift
[1518-08-31 00:04] Guard #1637 begins shift
[1518-10-22 00:14] falls asleep
[1518-04-19 00:04] Guard #3547 begins shift
[1518-06-15 00:01] falls asleep
[1518-06-08 00:46] wakes up
[1518-08-14 00:03] Guard #2693 begins shift
[1518-07-06 00:44] falls asleep
[1518-11-14 00:27] falls asleep
[1518-09-08 00:18] wakes up
[1518-07-02 00:45] wakes up
[1518-05-22 23:59] Guard #1699 begins shift
[1518-07-02 00:37] wakes up
[1518-07-31 00:16] falls asleep
[1518-08-30 00:12] falls asleep
[1518-09-06 00:01] Guard #409 begins shift
[1518-11-06 23:57] Guard #223 begins shift
[1518-11-23 00:24] falls asleep
[1518-04-18 00:36] falls asleep
[1518-11-18 00:16] wakes up
[1518-05-18 00:51] wakes up
[1518-03-29 00:48] wakes up
[1518-09-11 00:16] falls asleep";

            var guardLog = new GuardLog();
            var result1 = guardLog.GetGuardMostAsleepMin(input);
            var result2 = guardLog.GetGuardMostAsleepOnMinute(input);
            Console.WriteLine("Day 4 part 1 result: " + result1);
            Console.WriteLine("Day 4 part 2 result: " + result2);
        }

        private static void Day3()
        {
            var input = @"#1 @ 56,249: 24x16
#2 @ 682,730: 13x20
#3 @ 774,241: 22x23
#4 @ 503,41: 17x15
#5 @ 174,516: 17x15
#6 @ 1,184: 16x24
#7 @ 510,661: 15x29
#8 @ 396,504: 23x26
#9 @ 719,523: 26x20
#10 @ 189,795: 20x24
#11 @ 411,889: 20x16
#12 @ 346,203: 29x22
#13 @ 477,376: 18x27
#14 @ 824,946: 15x29
#15 @ 823,32: 23x26
#16 @ 124,118: 20x18
#17 @ 675,632: 22x26
#18 @ 925,385: 22x15
#19 @ 276,345: 16x13
#20 @ 24,322: 19x23
#21 @ 527,844: 23x26
#22 @ 862,187: 24x27
#23 @ 58,384: 13x20
#24 @ 835,921: 22x12
#25 @ 395,446: 21x27
#26 @ 769,46: 14x19
#27 @ 972,909: 21x10
#28 @ 178,504: 12x28
#29 @ 907,572: 10x21
#30 @ 90,810: 25x12
#31 @ 716,408: 11x26
#32 @ 160,501: 11x10
#33 @ 163,839: 22x26
#34 @ 514,876: 20x26
#35 @ 706,144: 26x16
#36 @ 872,226: 11x17
#37 @ 578,619: 26x15
#38 @ 218,638: 17x21
#39 @ 171,362: 17x17
#40 @ 263,499: 11x14
#41 @ 509,614: 21x14
#42 @ 415,287: 10x24
#43 @ 922,801: 13x25
#44 @ 167,753: 29x10
#45 @ 795,441: 18x22
#46 @ 803,590: 15x27
#47 @ 543,443: 22x15
#48 @ 944,275: 21x15
#49 @ 43,556: 22x29
#50 @ 5,141: 13x23
#51 @ 69,593: 12x19
#52 @ 843,688: 14x25
#53 @ 785,498: 23x29
#54 @ 581,191: 11x29
#55 @ 716,623: 19x13
#56 @ 146,494: 28x29
#57 @ 879,923: 29x23
#58 @ 777,194: 17x17
#59 @ 856,869: 18x19
#60 @ 160,869: 22x12
#61 @ 6,602: 15x24
#62 @ 536,814: 18x17
#63 @ 600,404: 22x23
#64 @ 717,183: 27x26
#65 @ 708,925: 16x15
#66 @ 135,628: 27x17
#67 @ 788,604: 28x27
#68 @ 668,649: 19x27
#69 @ 949,938: 11x25
#70 @ 187,587: 17x10
#71 @ 621,692: 22x27
#72 @ 939,485: 18x12
#73 @ 838,674: 27x18
#74 @ 567,398: 13x10
#75 @ 395,883: 10x22
#76 @ 754,327: 28x21
#77 @ 514,201: 26x13
#78 @ 749,396: 10x11
#79 @ 173,877: 11x17
#80 @ 880,764: 15x25
#81 @ 772,669: 10x11
#82 @ 961,272: 16x22
#83 @ 253,493: 10x20
#84 @ 541,569: 19x18
#85 @ 420,247: 24x19
#86 @ 536,944: 10x21
#87 @ 560,428: 21x26
#88 @ 558,971: 28x21
#89 @ 970,399: 14x22
#90 @ 724,569: 19x11
#91 @ 274,830: 21x28
#92 @ 358,451: 29x13
#93 @ 388,527: 19x13
#94 @ 968,814: 14x20
#95 @ 596,54: 26x12
#96 @ 473,832: 14x14
#97 @ 154,393: 22x28
#98 @ 221,736: 29x12
#99 @ 328,766: 11x10
#100 @ 959,790: 15x28
#101 @ 43,30: 14x18
#102 @ 27,918: 25x13
#103 @ 24,507: 19x17
#104 @ 922,708: 15x12
#105 @ 794,179: 13x10
#106 @ 537,476: 26x16
#107 @ 859,463: 27x26
#108 @ 686,401: 21x19
#109 @ 469,56: 22x17
#110 @ 727,493: 24x25
#111 @ 596,85: 25x13
#112 @ 632,77: 6x8
#113 @ 621,389: 20x25
#114 @ 311,404: 21x20
#115 @ 13,600: 21x24
#116 @ 69,595: 28x21
#117 @ 33,920: 18x22
#118 @ 667,370: 19x18
#119 @ 437,639: 13x22
#120 @ 879,633: 28x21
#121 @ 400,551: 21x10
#122 @ 70,105: 24x26
#123 @ 705,318: 14x21
#124 @ 17,34: 19x16
#125 @ 922,408: 18x23
#126 @ 56,231: 14x21
#127 @ 156,383: 25x28
#128 @ 562,569: 24x11
#129 @ 103,382: 26x22
#130 @ 691,346: 28x18
#131 @ 750,145: 28x27
#132 @ 924,789: 29x14
#133 @ 441,775: 29x10
#134 @ 189,873: 24x14
#135 @ 477,440: 15x23
#136 @ 174,876: 20x22
#137 @ 873,697: 24x13
#138 @ 874,755: 10x17
#139 @ 865,691: 12x26
#140 @ 390,449: 21x20
#141 @ 388,198: 26x18
#142 @ 942,242: 29x29
#143 @ 65,611: 11x28
#144 @ 47,415: 11x16
#145 @ 44,788: 16x25
#146 @ 756,589: 11x11
#147 @ 228,212: 25x24
#148 @ 291,163: 10x12
#149 @ 934,763: 25x29
#150 @ 475,932: 18x22
#151 @ 984,649: 11x11
#152 @ 518,241: 22x29
#153 @ 807,279: 16x19
#154 @ 361,732: 23x24
#155 @ 706,748: 15x12
#156 @ 651,388: 22x27
#157 @ 510,820: 18x20
#158 @ 589,448: 15x12
#159 @ 345,479: 29x11
#160 @ 145,746: 24x28
#161 @ 954,869: 25x16
#162 @ 165,854: 11x15
#163 @ 463,256: 12x27
#164 @ 332,653: 21x13
#165 @ 978,945: 16x22
#166 @ 868,516: 29x13
#167 @ 433,782: 27x29
#168 @ 400,789: 14x11
#169 @ 183,366: 28x14
#170 @ 356,56: 18x21
#171 @ 703,595: 18x26
#172 @ 479,19: 16x28
#173 @ 844,751: 21x12
#174 @ 164,508: 11x10
#175 @ 140,49: 26x22
#176 @ 701,48: 10x20
#177 @ 42,785: 22x15
#178 @ 912,932: 10x22
#179 @ 836,149: 10x24
#180 @ 587,285: 17x29
#181 @ 137,758: 29x18
#182 @ 731,72: 29x21
#183 @ 883,441: 26x12
#184 @ 910,484: 16x13
#185 @ 795,699: 12x14
#186 @ 396,461: 12x14
#187 @ 16,788: 22x24
#188 @ 423,243: 21x23
#189 @ 790,615: 23x12
#190 @ 923,394: 24x29
#191 @ 695,658: 16x12
#192 @ 276,973: 17x20
#193 @ 269,868: 10x17
#194 @ 945,647: 14x27
#195 @ 218,924: 12x29
#196 @ 567,421: 10x20
#197 @ 85,757: 20x17
#198 @ 714,168: 14x17
#199 @ 109,517: 27x19
#200 @ 391,215: 26x27
#201 @ 390,772: 12x21
#202 @ 350,338: 11x12
#203 @ 340,316: 11x10
#204 @ 376,459: 27x17
#205 @ 56,832: 19x15
#206 @ 565,70: 10x4
#207 @ 148,892: 18x13
#208 @ 863,163: 15x22
#209 @ 278,449: 24x19
#210 @ 458,127: 12x24
#211 @ 374,218: 14x21
#212 @ 692,942: 24x15
#213 @ 957,700: 24x17
#214 @ 548,448: 11x18
#215 @ 392,379: 18x20
#216 @ 802,279: 17x14
#217 @ 155,914: 26x14
#218 @ 500,152: 10x21
#219 @ 329,325: 28x25
#220 @ 200,762: 18x15
#221 @ 640,227: 15x17
#222 @ 132,611: 17x23
#223 @ 87,247: 20x16
#224 @ 171,388: 20x22
#225 @ 343,181: 11x27
#226 @ 551,954: 17x24
#227 @ 123,823: 23x27
#228 @ 771,224: 26x15
#229 @ 56,80: 26x13
#230 @ 118,575: 28x29
#231 @ 769,879: 24x20
#232 @ 519,943: 25x29
#233 @ 897,393: 15x19
#234 @ 202,805: 25x20
#235 @ 745,590: 23x28
#236 @ 540,300: 17x25
#237 @ 741,573: 11x17
#238 @ 718,174: 6x7
#239 @ 921,424: 19x26
#240 @ 641,730: 18x14
#241 @ 215,397: 18x12
#242 @ 262,633: 22x18
#243 @ 730,904: 23x23
#244 @ 323,305: 29x14
#245 @ 719,29: 12x23
#246 @ 923,670: 27x13
#247 @ 964,338: 13x26
#248 @ 13,648: 17x21
#249 @ 137,757: 11x12
#250 @ 799,185: 24x20
#251 @ 521,663: 26x11
#252 @ 580,188: 29x26
#253 @ 531,384: 17x28
#254 @ 46,320: 20x21
#255 @ 548,351: 23x20
#256 @ 136,64: 25x24
#257 @ 373,319: 12x22
#258 @ 238,949: 16x27
#259 @ 323,316: 13x11
#260 @ 960,172: 15x18
#261 @ 743,391: 15x17
#262 @ 229,535: 11x25
#263 @ 776,521: 14x20
#264 @ 803,763: 14x24
#265 @ 898,616: 19x18
#266 @ 97,240: 25x14
#267 @ 716,347: 13x29
#268 @ 1,136: 23x28
#269 @ 521,824: 24x13
#270 @ 204,824: 15x20
#271 @ 123,808: 14x18
#272 @ 958,885: 21x19
#273 @ 456,580: 10x11
#274 @ 160,579: 24x15
#275 @ 500,468: 19x28
#276 @ 282,826: 15x16
#277 @ 444,312: 11x13
#278 @ 334,715: 8x3
#279 @ 723,604: 25x25
#280 @ 898,173: 20x13
#281 @ 357,8: 14x19
#282 @ 522,649: 26x17
#283 @ 676,863: 17x17
#284 @ 603,972: 3x7
#285 @ 290,330: 21x25
#286 @ 508,45: 13x16
#287 @ 464,402: 16x19
#288 @ 383,427: 21x21
#289 @ 80,125: 21x11
#290 @ 399,639: 23x19
#291 @ 461,929: 23x11
#292 @ 921,185: 24x24
#293 @ 947,249: 17x21
#294 @ 676,504: 15x11
#295 @ 252,950: 11x25
#296 @ 125,918: 27x27
#297 @ 136,729: 10x15
#298 @ 645,166: 18x28
#299 @ 477,835: 25x28
#300 @ 330,303: 20x15
#301 @ 796,398: 19x26
#302 @ 125,408: 28x15
#303 @ 206,774: 25x17
#304 @ 380,794: 12x15
#305 @ 435,242: 12x22
#306 @ 258,343: 23x15
#307 @ 8,119: 29x23
#308 @ 899,941: 20x17
#309 @ 838,59: 21x15
#310 @ 971,355: 24x17
#311 @ 810,178: 19x14
#312 @ 223,629: 24x23
#313 @ 208,145: 18x22
#314 @ 400,815: 11x14
#315 @ 866,630: 22x28
#316 @ 32,283: 20x25
#317 @ 120,560: 29x26
#318 @ 916,420: 13x12
#319 @ 800,122: 17x20
#320 @ 126,522: 13x10
#321 @ 608,494: 11x16
#322 @ 569,420: 12x10
#323 @ 563,435: 23x12
#324 @ 739,606: 17x10
#325 @ 900,756: 18x18
#326 @ 877,317: 11x16
#327 @ 754,29: 27x23
#328 @ 926,466: 10x24
#329 @ 760,890: 29x27
#330 @ 216,328: 27x28
#331 @ 123,782: 29x11
#332 @ 630,142: 20x27
#333 @ 480,293: 10x13
#334 @ 941,803: 22x11
#335 @ 448,260: 17x23
#336 @ 188,500: 16x18
#337 @ 621,398: 15x22
#338 @ 356,770: 19x27
#339 @ 767,162: 10x16
#340 @ 587,184: 18x23
#341 @ 641,49: 14x11
#342 @ 625,418: 16x16
#343 @ 131,172: 23x27
#344 @ 740,918: 20x13
#345 @ 256,861: 23x25
#346 @ 49,961: 12x16
#347 @ 161,62: 28x14
#348 @ 663,628: 24x21
#349 @ 673,725: 12x15
#350 @ 39,920: 6x7
#351 @ 28,328: 12x28
#352 @ 703,53: 28x10
#353 @ 158,206: 25x29
#354 @ 669,634: 13x25
#355 @ 4,635: 28x17
#356 @ 52,430: 21x16
#357 @ 878,210: 13x19
#358 @ 436,477: 6x6
#359 @ 415,63: 21x28
#360 @ 103,424: 23x25
#361 @ 463,843: 12x18
#362 @ 830,926: 10x11
#363 @ 142,618: 18x23
#364 @ 430,236: 14x12
#365 @ 920,417: 15x17
#366 @ 922,417: 18x23
#367 @ 960,184: 13x12
#368 @ 659,34: 24x26
#369 @ 912,619: 19x18
#370 @ 336,306: 12x27
#371 @ 906,691: 22x22
#372 @ 472,528: 10x29
#373 @ 972,642: 13x29
#374 @ 738,288: 28x27
#375 @ 741,711: 20x18
#376 @ 962,463: 15x20
#377 @ 157,249: 16x22
#378 @ 155,220: 24x21
#379 @ 763,329: 21x22
#380 @ 663,204: 14x28
#381 @ 692,25: 16x18
#382 @ 938,796: 25x16
#383 @ 127,143: 29x19
#384 @ 27,658: 21x14
#385 @ 840,140: 15x22
#386 @ 946,264: 19x13
#387 @ 207,441: 24x14
#388 @ 369,943: 20x26
#389 @ 801,319: 29x14
#390 @ 562,677: 20x27
#391 @ 110,962: 21x22
#392 @ 788,841: 18x26
#393 @ 92,886: 19x21
#394 @ 534,803: 29x25
#395 @ 400,661: 16x15
#396 @ 730,237: 20x27
#397 @ 970,794: 17x28
#398 @ 399,556: 23x15
#399 @ 422,200: 16x14
#400 @ 395,398: 21x10
#401 @ 354,858: 26x17
#402 @ 806,121: 14x29
#403 @ 40,719: 17x17
#404 @ 223,647: 16x23
#405 @ 744,68: 10x24
#406 @ 668,506: 16x20
#407 @ 423,982: 23x17
#408 @ 939,248: 11x24
#409 @ 776,82: 19x16
#410 @ 486,446: 16x10
#411 @ 629,377: 16x18
#412 @ 450,550: 26x17
#413 @ 801,403: 18x26
#414 @ 781,386: 26x23
#415 @ 862,423: 10x23
#416 @ 175,614: 25x15
#417 @ 879,651: 11x10
#418 @ 55,58: 23x23
#419 @ 693,616: 21x25
#420 @ 437,408: 12x21
#421 @ 250,464: 12x14
#422 @ 948,314: 17x24
#423 @ 2,29: 17x24
#424 @ 925,671: 12x13
#425 @ 431,622: 12x22
#426 @ 174,244: 12x29
#427 @ 169,916: 24x24
#428 @ 498,761: 25x24
#429 @ 935,383: 11x20
#430 @ 816,919: 18x14
#431 @ 612,585: 19x22
#432 @ 950,889: 23x21
#433 @ 449,426: 16x12
#434 @ 225,812: 23x26
#435 @ 17,686: 29x23
#436 @ 773,111: 20x15
#437 @ 746,602: 22x10
#438 @ 892,743: 19x25
#439 @ 106,432: 24x19
#440 @ 186,899: 13x25
#441 @ 379,227: 21x13
#442 @ 421,303: 24x13
#443 @ 952,713: 16x27
#444 @ 225,923: 23x29
#445 @ 795,31: 12x12
#446 @ 618,116: 17x26
#447 @ 626,614: 11x16
#448 @ 678,63: 26x15
#449 @ 217,933: 19x24
#450 @ 706,914: 28x15
#451 @ 450,742: 25x21
#452 @ 358,84: 14x29
#453 @ 777,144: 24x13
#454 @ 162,936: 18x15
#455 @ 826,59: 8x16
#456 @ 148,516: 29x16
#457 @ 620,443: 27x27
#458 @ 58,713: 13x24
#459 @ 183,475: 26x29
#460 @ 31,452: 28x12
#461 @ 592,623: 22x28
#462 @ 585,770: 20x22
#463 @ 453,534: 19x18
#464 @ 157,891: 26x20
#465 @ 645,222: 14x19
#466 @ 258,259: 23x17
#467 @ 295,682: 12x5
#468 @ 398,273: 16x12
#469 @ 890,128: 25x11
#470 @ 936,254: 26x26
#471 @ 526,644: 28x17
#472 @ 103,758: 16x25
#473 @ 727,238: 29x16
#474 @ 918,597: 11x25
#475 @ 628,71: 15x23
#476 @ 276,828: 17x11
#477 @ 565,202: 27x15
#478 @ 155,668: 19x20
#479 @ 171,471: 15x27
#480 @ 719,53: 29x26
#481 @ 390,645: 26x22
#482 @ 527,858: 12x11
#483 @ 284,235: 18x13
#484 @ 491,822: 28x17
#485 @ 693,29: 12x10
#486 @ 281,238: 18x13
#487 @ 972,273: 18x23
#488 @ 846,835: 19x29
#489 @ 86,237: 24x27
#490 @ 715,31: 16x12
#491 @ 658,569: 3x16
#492 @ 749,45: 15x17
#493 @ 586,62: 23x24
#494 @ 176,849: 19x29
#495 @ 736,673: 10x19
#496 @ 339,469: 12x16
#497 @ 231,88: 17x28
#498 @ 706,332: 22x18
#499 @ 570,251: 19x25
#500 @ 567,692: 17x26
#501 @ 267,890: 27x25
#502 @ 872,176: 22x12
#503 @ 611,396: 14x26
#504 @ 220,809: 16x26
#505 @ 809,830: 13x23
#506 @ 761,101: 14x22
#507 @ 223,12: 12x23
#508 @ 554,37: 19x11
#509 @ 186,756: 20x13
#510 @ 502,692: 28x15
#511 @ 625,338: 11x29
#512 @ 128,115: 26x21
#513 @ 957,247: 25x20
#514 @ 401,268: 25x23
#515 @ 511,650: 25x17
#516 @ 43,26: 25x25
#517 @ 916,477: 22x11
#518 @ 942,157: 20x17
#519 @ 9,321: 29x25
#520 @ 789,25: 16x15
#521 @ 902,171: 29x18
#522 @ 807,597: 10x12
#523 @ 51,807: 15x23
#524 @ 826,479: 20x20
#525 @ 426,181: 12x21
#526 @ 892,150: 16x29
#527 @ 562,598: 12x11
#528 @ 636,481: 15x28
#529 @ 446,205: 23x15
#530 @ 143,583: 18x29
#531 @ 508,247: 12x23
#532 @ 596,858: 18x16
#533 @ 365,378: 13x20
#534 @ 157,175: 24x21
#535 @ 262,517: 16x15
#536 @ 723,803: 8x5
#537 @ 8,157: 22x19
#538 @ 69,284: 28x16
#539 @ 496,632: 23x13
#540 @ 781,176: 20x13
#541 @ 624,180: 17x17
#542 @ 413,834: 14x10
#543 @ 633,366: 29x25
#544 @ 108,188: 14x24
#545 @ 502,216: 21x10
#546 @ 83,183: 13x17
#547 @ 708,164: 15x28
#548 @ 359,318: 21x26
#549 @ 967,915: 18x25
#550 @ 169,511: 15x25
#551 @ 947,331: 18x12
#552 @ 478,217: 26x21
#553 @ 822,122: 22x28
#554 @ 719,678: 12x16
#555 @ 807,359: 20x20
#556 @ 16,639: 9x9
#557 @ 244,933: 24x12
#558 @ 367,577: 13x11
#559 @ 164,919: 21x21
#560 @ 673,732: 18x10
#561 @ 843,508: 27x28
#562 @ 271,626: 19x12
#563 @ 805,375: 28x12
#564 @ 369,509: 15x27
#565 @ 446,862: 25x21
#566 @ 262,910: 28x18
#567 @ 241,249: 19x22
#568 @ 642,138: 13x29
#569 @ 647,159: 22x25
#570 @ 956,375: 25x28
#571 @ 565,915: 21x18
#572 @ 884,449: 27x18
#573 @ 254,493: 16x24
#574 @ 231,577: 21x13
#575 @ 573,336: 14x8
#576 @ 44,414: 25x27
#577 @ 41,381: 25x27
#578 @ 429,530: 29x12
#579 @ 245,24: 12x29
#580 @ 592,182: 22x29
#581 @ 66,40: 16x12
#582 @ 833,508: 19x25
#583 @ 14,322: 10x27
#584 @ 173,825: 24x22
#585 @ 79,662: 28x19
#586 @ 105,53: 13x15
#587 @ 369,597: 12x12
#588 @ 624,37: 23x14
#589 @ 155,415: 13x18
#590 @ 643,466: 16x16
#591 @ 103,254: 18x21
#592 @ 485,920: 11x10
#593 @ 495,316: 16x29
#594 @ 717,604: 18x27
#595 @ 906,817: 26x29
#596 @ 353,320: 29x26
#597 @ 823,322: 14x18
#598 @ 58,815: 12x28
#599 @ 165,154: 22x24
#600 @ 690,330: 27x18
#601 @ 416,930: 16x26
#602 @ 799,424: 10x11
#603 @ 346,662: 10x23
#604 @ 208,500: 27x23
#605 @ 642,368: 22x13
#606 @ 855,102: 28x22
#607 @ 682,310: 27x13
#608 @ 464,16: 20x15
#609 @ 116,379: 14x10
#610 @ 499,198: 23x29
#611 @ 943,863: 26x18
#612 @ 797,178: 28x26
#613 @ 885,383: 28x22
#614 @ 535,291: 22x28
#615 @ 888,126: 10x28
#616 @ 656,823: 13x18
#617 @ 22,640: 3x9
#618 @ 105,569: 19x21
#619 @ 598,911: 11x11
#620 @ 842,364: 28x15
#621 @ 116,529: 18x10
#622 @ 630,760: 21x16
#623 @ 827,721: 14x19
#624 @ 235,104: 8x7
#625 @ 74,164: 11x15
#626 @ 889,943: 29x21
#627 @ 74,155: 26x22
#628 @ 790,76: 26x28
#629 @ 809,349: 10x22
#630 @ 793,324: 10x24
#631 @ 154,151: 18x20
#632 @ 600,145: 14x20
#633 @ 26,806: 28x18
#634 @ 376,515: 13x14
#635 @ 170,478: 24x25
#636 @ 626,749: 20x19
#637 @ 739,254: 22x22
#638 @ 135,634: 25x15
#639 @ 238,1: 26x26
#640 @ 343,277: 19x12
#641 @ 606,683: 16x23
#642 @ 597,951: 12x11
#643 @ 173,932: 27x24
#644 @ 865,295: 29x15
#645 @ 847,902: 15x11
#646 @ 434,475: 12x13
#647 @ 590,271: 10x21
#648 @ 776,50: 28x15
#649 @ 698,935: 26x18
#650 @ 599,751: 20x26
#651 @ 797,390: 14x17
#652 @ 257,335: 19x27
#653 @ 73,876: 22x28
#654 @ 710,698: 10x13
#655 @ 368,318: 18x23
#656 @ 80,179: 16x20
#657 @ 5,957: 21x28
#658 @ 885,768: 18x13
#659 @ 734,414: 10x13
#660 @ 779,520: 23x23
#661 @ 615,604: 11x12
#662 @ 747,253: 28x18
#663 @ 66,285: 10x22
#664 @ 350,543: 12x24
#665 @ 526,77: 19x18
#666 @ 824,888: 14x16
#667 @ 365,567: 18x26
#668 @ 597,550: 22x16
#669 @ 874,613: 19x19
#670 @ 730,91: 14x14
#671 @ 882,284: 27x13
#672 @ 902,117: 10x10
#673 @ 610,497: 6x9
#674 @ 583,646: 25x16
#675 @ 797,824: 27x22
#676 @ 156,570: 19x12
#677 @ 118,94: 12x11
#678 @ 515,626: 11x17
#679 @ 947,286: 20x10
#680 @ 885,51: 23x23
#681 @ 280,636: 11x27
#682 @ 610,392: 28x15
#683 @ 575,134: 17x20
#684 @ 978,455: 22x16
#685 @ 637,282: 21x17
#686 @ 486,662: 25x29
#687 @ 655,489: 21x29
#688 @ 369,451: 14x17
#689 @ 127,416: 21x25
#690 @ 910,899: 12x11
#691 @ 952,342: 10x19
#692 @ 182,517: 13x29
#693 @ 171,159: 22x19
#694 @ 721,801: 25x11
#695 @ 438,472: 27x26
#696 @ 974,4: 16x29
#697 @ 47,35: 10x18
#698 @ 802,380: 19x13
#699 @ 652,2: 15x13
#700 @ 828,712: 13x13
#701 @ 154,147: 17x12
#702 @ 706,327: 14x13
#703 @ 551,100: 28x27
#704 @ 454,923: 10x24
#705 @ 590,66: 18x14
#706 @ 943,158: 12x25
#707 @ 974,324: 11x24
#708 @ 968,931: 25x21
#709 @ 249,203: 10x21
#710 @ 909,210: 15x22
#711 @ 404,659: 17x21
#712 @ 317,281: 29x19
#713 @ 174,58: 13x27
#714 @ 16,646: 13x25
#715 @ 216,369: 26x16
#716 @ 960,257: 29x21
#717 @ 969,867: 21x21
#718 @ 357,583: 29x21
#719 @ 554,21: 24x17
#720 @ 934,332: 16x16
#721 @ 451,877: 27x21
#722 @ 584,47: 12x25
#723 @ 707,748: 19x16
#724 @ 754,93: 29x20
#725 @ 310,862: 24x10
#726 @ 127,472: 29x21
#727 @ 183,34: 10x11
#728 @ 503,489: 20x23
#729 @ 770,27: 10x18
#730 @ 526,272: 10x5
#731 @ 742,213: 22x14
#732 @ 936,798: 22x19
#733 @ 735,318: 27x23
#734 @ 615,460: 27x22
#735 @ 643,426: 26x28
#736 @ 696,657: 22x24
#737 @ 319,771: 19x19
#738 @ 721,277: 28x16
#739 @ 257,342: 13x22
#740 @ 950,859: 13x16
#741 @ 244,369: 26x11
#742 @ 386,227: 26x12
#743 @ 680,670: 11x24
#744 @ 447,316: 15x25
#745 @ 157,899: 23x20
#746 @ 646,279: 16x17
#747 @ 9,185: 24x26
#748 @ 969,900: 26x20
#749 @ 973,876: 10x12
#750 @ 235,449: 17x11
#751 @ 934,800: 12x13
#752 @ 642,144: 25x14
#753 @ 645,27: 25x24
#754 @ 174,272: 22x14
#755 @ 24,541: 29x16
#756 @ 796,380: 22x15
#757 @ 681,765: 19x22
#758 @ 133,102: 25x22
#759 @ 174,845: 20x25
#760 @ 568,394: 14x25
#761 @ 59,245: 27x17
#762 @ 369,596: 25x15
#763 @ 13,633: 21x21
#764 @ 949,458: 22x21
#765 @ 47,958: 16x28
#766 @ 781,673: 12x26
#767 @ 944,811: 16x24
#768 @ 98,45: 21x13
#769 @ 308,781: 20x13
#770 @ 382,206: 24x18
#771 @ 367,773: 19x29
#772 @ 842,735: 27x25
#773 @ 89,458: 16x23
#774 @ 435,238: 4x3
#775 @ 376,327: 11x18
#776 @ 167,16: 21x23
#777 @ 832,77: 15x14
#778 @ 800,490: 28x23
#779 @ 209,462: 18x15
#780 @ 445,492: 14x23
#781 @ 38,486: 19x22
#782 @ 845,489: 26x29
#783 @ 328,789: 17x25
#784 @ 327,305: 27x29
#785 @ 957,97: 25x21
#786 @ 69,169: 10x14
#787 @ 626,227: 20x29
#788 @ 190,589: 4x4
#789 @ 817,119: 18x14
#790 @ 861,514: 14x10
#791 @ 770,180: 19x16
#792 @ 403,900: 17x12
#793 @ 532,923: 15x25
#794 @ 966,361: 26x19
#795 @ 628,400: 26x25
#796 @ 794,759: 15x21
#797 @ 909,211: 21x12
#798 @ 67,402: 28x16
#799 @ 524,270: 15x11
#800 @ 665,360: 20x12
#801 @ 898,41: 25x15
#802 @ 307,387: 16x23
#803 @ 210,323: 24x26
#804 @ 570,332: 29x23
#805 @ 660,619: 27x12
#806 @ 556,536: 26x17
#807 @ 349,306: 10x26
#808 @ 287,678: 25x22
#809 @ 522,796: 15x25
#810 @ 388,802: 15x19
#811 @ 472,188: 24x15
#812 @ 422,247: 26x20
#813 @ 371,934: 21x19
#814 @ 112,226: 20x15
#815 @ 233,12: 23x19
#816 @ 492,131: 10x23
#817 @ 540,578: 19x12
#818 @ 142,624: 12x10
#819 @ 50,732: 11x25
#820 @ 462,196: 18x17
#821 @ 161,631: 28x21
#822 @ 915,66: 28x29
#823 @ 149,218: 12x24
#824 @ 209,322: 29x25
#825 @ 586,527: 18x10
#826 @ 772,344: 26x25
#827 @ 600,522: 12x21
#828 @ 975,346: 17x27
#829 @ 710,244: 10x22
#830 @ 189,930: 25x21
#831 @ 618,614: 11x14
#832 @ 500,203: 16x20
#833 @ 817,57: 25x22
#834 @ 198,932: 16x11
#835 @ 74,277: 15x17
#836 @ 559,289: 12x29
#837 @ 240,942: 14x26
#838 @ 938,98: 10x27
#839 @ 599,508: 24x18
#840 @ 547,636: 20x10
#841 @ 639,127: 13x24
#842 @ 558,689: 28x15
#843 @ 846,635: 22x21
#844 @ 571,773: 28x17
#845 @ 697,687: 18x24
#846 @ 350,208: 16x24
#847 @ 248,639: 17x10
#848 @ 468,840: 14x29
#849 @ 965,911: 23x21
#850 @ 632,779: 17x21
#851 @ 801,310: 11x21
#852 @ 161,492: 12x21
#853 @ 594,593: 21x19
#854 @ 879,271: 13x25
#855 @ 705,76: 29x21
#856 @ 847,151: 22x12
#857 @ 577,396: 23x20
#858 @ 246,708: 18x28
#859 @ 969,100: 4x5
#860 @ 643,703: 10x29
#861 @ 222,935: 29x23
#862 @ 872,761: 12x22
#863 @ 886,932: 11x10
#864 @ 936,948: 19x12
#865 @ 29,34: 14x22
#866 @ 787,231: 17x29
#867 @ 481,263: 16x17
#868 @ 440,247: 13x13
#869 @ 327,774: 14x29
#870 @ 20,948: 11x11
#871 @ 368,523: 16x23
#872 @ 921,206: 13x28
#873 @ 886,939: 10x13
#874 @ 962,75: 10x17
#875 @ 153,851: 26x27
#876 @ 919,446: 14x17
#877 @ 736,539: 21x10
#878 @ 886,129: 27x15
#879 @ 828,731: 21x18
#880 @ 400,657: 23x13
#881 @ 164,209: 27x15
#882 @ 743,75: 9x14
#883 @ 390,102: 25x21
#884 @ 56,626: 17x21
#885 @ 587,269: 26x13
#886 @ 529,152: 13x20
#887 @ 121,948: 27x27
#888 @ 145,270: 25x23
#889 @ 55,926: 12x23
#890 @ 724,370: 29x29
#891 @ 922,609: 23x15
#892 @ 525,468: 24x26
#893 @ 554,937: 11x24
#894 @ 217,471: 22x27
#895 @ 314,281: 10x26
#896 @ 653,457: 12x25
#897 @ 739,541: 24x10
#898 @ 642,376: 14x26
#899 @ 132,520: 22x25
#900 @ 635,769: 3x15
#901 @ 884,755: 25x24
#902 @ 712,334: 10x11
#903 @ 494,760: 28x17
#904 @ 165,612: 16x22
#905 @ 779,183: 18x20
#906 @ 900,464: 17x23
#907 @ 867,768: 26x22
#908 @ 831,78: 19x14
#909 @ 586,477: 26x12
#910 @ 534,646: 25x18
#911 @ 372,471: 26x17
#912 @ 926,831: 14x11
#913 @ 840,686: 21x11
#914 @ 710,676: 13x17
#915 @ 442,244: 19x23
#916 @ 70,595: 25x12
#917 @ 34,921: 25x21
#918 @ 271,330: 26x22
#919 @ 470,254: 14x22
#920 @ 142,906: 25x15
#921 @ 439,425: 15x15
#922 @ 600,970: 12x15
#923 @ 482,4: 23x22
#924 @ 203,175: 17x13
#925 @ 102,725: 18x17
#926 @ 969,757: 16x11
#927 @ 430,942: 11x16
#928 @ 723,182: 18x29
#929 @ 773,222: 11x19
#930 @ 32,20: 19x28
#931 @ 817,929: 18x21
#932 @ 560,593: 11x16
#933 @ 576,81: 29x25
#934 @ 212,559: 29x14
#935 @ 402,635: 19x18
#936 @ 792,696: 14x21
#937 @ 518,652: 11x4
#938 @ 492,750: 27x15
#939 @ 688,224: 27x21
#940 @ 890,114: 16x19
#941 @ 944,295: 22x22
#942 @ 41,640: 19x25
#943 @ 376,371: 11x19
#944 @ 148,510: 16x20
#945 @ 815,930: 18x12
#946 @ 947,299: 26x22
#947 @ 153,882: 10x13
#948 @ 754,209: 23x15
#949 @ 492,90: 25x13
#950 @ 877,225: 17x19
#951 @ 729,147: 20x17
#952 @ 162,464: 21x27
#953 @ 684,882: 28x28
#954 @ 698,255: 24x16
#955 @ 349,8: 27x24
#956 @ 67,13: 19x25
#957 @ 170,860: 12x16
#958 @ 411,947: 23x25
#959 @ 858,516: 17x29
#960 @ 609,390: 13x14
#961 @ 513,84: 21x11
#962 @ 867,298: 18x8
#963 @ 89,661: 16x14
#964 @ 435,654: 14x19
#965 @ 519,153: 11x10
#966 @ 280,975: 20x20
#967 @ 13,326: 11x11
#968 @ 112,776: 23x15
#969 @ 465,174: 12x26
#970 @ 38,231: 17x14
#971 @ 783,705: 26x28
#972 @ 456,419: 28x27
#973 @ 388,143: 22x29
#974 @ 19,422: 21x23
#975 @ 260,195: 25x22
#976 @ 165,782: 17x14
#977 @ 855,640: 14x20
#978 @ 912,575: 24x17
#979 @ 396,832: 20x16
#980 @ 286,834: 26x21
#981 @ 801,420: 11x14
#982 @ 857,902: 25x26
#983 @ 317,94: 17x12
#984 @ 944,863: 17x29
#985 @ 605,638: 25x11
#986 @ 456,136: 15x23
#987 @ 533,807: 10x15
#988 @ 517,400: 19x14
#989 @ 792,709: 27x29
#990 @ 471,106: 6x18
#991 @ 413,277: 22x13
#992 @ 482,705: 23x27
#993 @ 830,491: 16x25
#994 @ 396,179: 19x22
#995 @ 671,607: 22x19
#996 @ 288,145: 20x14
#997 @ 534,400: 16x24
#998 @ 239,333: 20x12
#999 @ 801,307: 12x24
#1000 @ 714,606: 12x18
#1001 @ 627,784: 22x11
#1002 @ 734,20: 27x14
#1003 @ 262,645: 23x14
#1004 @ 445,670: 13x12
#1005 @ 304,443: 21x24
#1006 @ 199,5: 10x23
#1007 @ 907,64: 25x13
#1008 @ 553,953: 10x16
#1009 @ 972,744: 26x20
#1010 @ 766,180: 16x20
#1011 @ 558,413: 29x11
#1012 @ 299,456: 22x10
#1013 @ 263,138: 29x13
#1014 @ 746,17: 10x21
#1015 @ 224,697: 27x19
#1016 @ 182,609: 25x12
#1017 @ 508,324: 20x10
#1018 @ 758,200: 13x24
#1019 @ 222,788: 24x13
#1020 @ 254,197: 25x19
#1021 @ 169,168: 22x20
#1022 @ 618,120: 15x24
#1023 @ 932,388: 4x7
#1024 @ 220,142: 29x14
#1025 @ 784,9: 16x15
#1026 @ 658,715: 16x28
#1027 @ 807,128: 29x28
#1028 @ 128,240: 12x25
#1029 @ 685,895: 19x27
#1030 @ 582,930: 21x27
#1031 @ 482,325: 25x22
#1032 @ 659,442: 10x18
#1033 @ 752,690: 20x16
#1034 @ 168,762: 11x23
#1035 @ 30,202: 26x20
#1036 @ 290,442: 26x12
#1037 @ 439,941: 27x23
#1038 @ 563,121: 14x28
#1039 @ 153,308: 22x11
#1040 @ 743,157: 10x13
#1041 @ 173,939: 12x16
#1042 @ 334,562: 22x13
#1043 @ 142,581: 25x20
#1044 @ 195,609: 17x16
#1045 @ 410,895: 19x20
#1046 @ 233,495: 23x29
#1047 @ 351,242: 24x13
#1048 @ 595,641: 11x10
#1049 @ 434,465: 19x11
#1050 @ 418,672: 19x10
#1051 @ 872,314: 22x25
#1052 @ 631,721: 12x22
#1053 @ 738,839: 28x28
#1054 @ 49,226: 13x17
#1055 @ 271,199: 16x13
#1056 @ 200,828: 17x23
#1057 @ 546,342: 10x16
#1058 @ 6,166: 19x28
#1059 @ 175,581: 22x23
#1060 @ 36,665: 13x14
#1061 @ 685,42: 14x22
#1062 @ 282,626: 20x17
#1063 @ 137,758: 23x26
#1064 @ 105,205: 15x22
#1065 @ 817,925: 21x14
#1066 @ 608,901: 18x25
#1067 @ 153,685: 13x13
#1068 @ 745,162: 24x29
#1069 @ 942,601: 16x22
#1070 @ 690,776: 21x17
#1071 @ 457,26: 12x14
#1072 @ 224,27: 18x14
#1073 @ 589,622: 29x13
#1074 @ 479,270: 16x21
#1075 @ 257,737: 11x28
#1076 @ 122,195: 21x19
#1077 @ 68,178: 17x10
#1078 @ 28,727: 16x11
#1079 @ 726,482: 20x16
#1080 @ 39,923: 28x23
#1081 @ 352,372: 29x15
#1082 @ 786,670: 23x10
#1083 @ 153,160: 24x11
#1084 @ 235,325: 16x18
#1085 @ 484,0: 10x25
#1086 @ 22,36: 18x17
#1087 @ 785,243: 6x17
#1088 @ 505,198: 10x17
#1089 @ 485,287: 16x10
#1090 @ 466,342: 23x18
#1091 @ 157,292: 19x22
#1092 @ 641,606: 22x29
#1093 @ 605,171: 25x19
#1094 @ 562,903: 29x13
#1095 @ 653,3: 19x18
#1096 @ 601,848: 21x19
#1097 @ 119,454: 18x24
#1098 @ 819,876: 14x10
#1099 @ 939,737: 25x23
#1100 @ 662,614: 27x12
#1101 @ 708,183: 11x14
#1102 @ 353,47: 27x11
#1103 @ 6,670: 12x27
#1104 @ 438,504: 24x24
#1105 @ 854,210: 20x23
#1106 @ 661,859: 24x13
#1107 @ 813,936: 27x12
#1108 @ 285,470: 26x18
#1109 @ 872,122: 11x15
#1110 @ 799,825: 21x11
#1111 @ 453,59: 19x24
#1112 @ 571,600: 27x25
#1113 @ 870,224: 16x22
#1114 @ 11,16: 14x23
#1115 @ 959,347: 22x25
#1116 @ 137,931: 24x19
#1117 @ 435,79: 22x28
#1118 @ 37,318: 14x18
#1119 @ 332,280: 22x11
#1120 @ 434,950: 18x18
#1121 @ 380,426: 25x23
#1122 @ 362,749: 15x13
#1123 @ 216,589: 21x11
#1124 @ 228,740: 26x26
#1125 @ 799,949: 26x14
#1126 @ 691,948: 14x16
#1127 @ 742,230: 25x20
#1128 @ 174,881: 21x12
#1129 @ 904,625: 13x12
#1130 @ 52,413: 19x13
#1131 @ 224,443: 12x15
#1132 @ 680,361: 29x10
#1133 @ 625,430: 27x23
#1134 @ 378,494: 11x18
#1135 @ 472,922: 23x11
#1136 @ 694,958: 20x14
#1137 @ 561,571: 17x16
#1138 @ 356,863: 21x7
#1139 @ 626,779: 13x27
#1140 @ 469,284: 17x23
#1141 @ 4,673: 22x18
#1142 @ 342,176: 28x11
#1143 @ 17,450: 16x11
#1144 @ 784,389: 14x22
#1145 @ 97,436: 10x19
#1146 @ 934,692: 27x11
#1147 @ 555,625: 29x18
#1148 @ 253,456: 19x17
#1149 @ 75,145: 24x17
#1150 @ 544,857: 14x14
#1151 @ 664,825: 27x18
#1152 @ 20,578: 24x11
#1153 @ 376,222: 14x18
#1154 @ 214,762: 14x12
#1155 @ 753,247: 12x22
#1156 @ 728,675: 19x27
#1157 @ 768,649: 28x23
#1158 @ 647,363: 23x22
#1159 @ 893,223: 14x24
#1160 @ 727,519: 12x25
#1161 @ 718,616: 11x16
#1162 @ 415,970: 15x24
#1163 @ 89,898: 11x14
#1164 @ 868,883: 27x13
#1165 @ 67,270: 29x22
#1166 @ 263,480: 27x26
#1167 @ 466,949: 17x26
#1168 @ 653,562: 15x28
#1169 @ 58,371: 26x22
#1170 @ 761,22: 29x11
#1171 @ 139,546: 27x18
#1172 @ 58,600: 13x23
#1173 @ 716,595: 12x27
#1174 @ 196,845: 12x14
#1175 @ 576,447: 24x10
#1176 @ 319,314: 20x21
#1177 @ 10,705: 11x15
#1178 @ 430,933: 27x11
#1179 @ 795,447: 18x26
#1180 @ 924,782: 27x24
#1181 @ 695,609: 18x13
#1182 @ 600,180: 28x28
#1183 @ 929,475: 25x23
#1184 @ 363,776: 13x26
#1185 @ 888,206: 17x14
#1186 @ 876,136: 23x14
#1187 @ 332,16: 20x10
#1188 @ 554,966: 14x20
#1189 @ 418,342: 20x19
#1190 @ 175,826: 16x14
#1191 @ 528,385: 15x29
#1192 @ 925,117: 20x29
#1193 @ 716,849: 23x13
#1194 @ 164,394: 20x12
#1195 @ 513,81: 24x13
#1196 @ 841,475: 19x11
#1197 @ 468,104: 14x24
#1198 @ 806,495: 13x29
#1199 @ 682,669: 29x16
#1200 @ 429,776: 22x14
#1201 @ 767,685: 29x25
#1202 @ 398,881: 19x15
#1203 @ 723,469: 22x18
#1204 @ 158,738: 27x25
#1205 @ 816,896: 11x18
#1206 @ 780,498: 21x16
#1207 @ 927,341: 15x16
#1208 @ 826,55: 27x18
#1209 @ 148,762: 24x11
#1210 @ 556,546: 15x10
#1211 @ 836,805: 26x15
#1212 @ 548,794: 23x21
#1213 @ 775,340: 11x18
#1214 @ 54,390: 12x20
#1215 @ 563,64: 24x14
#1216 @ 569,693: 12x22
#1217 @ 325,866: 25x22
#1218 @ 753,611: 16x25
#1219 @ 654,480: 13x29
#1220 @ 83,255: 16x18
#1221 @ 425,242: 23x20
#1222 @ 350,590: 17x19
#1223 @ 29,798: 10x27
#1224 @ 147,92: 15x20
#1225 @ 10,676: 15x21
#1226 @ 93,103: 28x20
#1227 @ 361,98: 20x16
#1228 @ 552,300: 19x19
#1229 @ 362,594: 20x29
#1230 @ 509,889: 11x25
#1231 @ 587,473: 19x17
#1232 @ 710,387: 12x25
#1233 @ 803,831: 20x26
#1234 @ 102,938: 21x17
#1235 @ 32,505: 27x10
#1236 @ 798,885: 25x26
#1237 @ 786,1: 18x28
#1238 @ 830,673: 29x27
#1239 @ 569,427: 4x10
#1240 @ 236,226: 17x26
#1241 @ 438,642: 11x24
#1242 @ 713,305: 23x24
#1243 @ 51,795: 18x13
#1244 @ 549,847: 27x24
#1245 @ 642,460: 18x13
#1246 @ 399,222: 13x16
#1247 @ 161,480: 19x10
#1248 @ 888,226: 27x23
#1249 @ 274,237: 26x28
#1250 @ 16,323: 20x25
#1251 @ 412,329: 24x19
#1252 @ 377,188: 23x14
#1253 @ 288,439: 19x22
#1254 @ 759,110: 11x27
#1255 @ 400,420: 21x13
#1256 @ 446,663: 25x15
#1257 @ 782,141: 11x19
#1258 @ 374,442: 21x28
#1259 @ 587,402: 13x11
#1260 @ 78,152: 29x25
#1261 @ 816,182: 6x4
#1262 @ 382,939: 24x29
#1263 @ 256,592: 12x27
#1264 @ 83,909: 24x21
#1265 @ 447,581: 13x17
#1266 @ 679,654: 24x11
#1267 @ 631,223: 15x26
#1268 @ 180,366: 12x19
#1269 @ 823,742: 12x15
#1270 @ 221,290: 24x16
#1271 @ 207,653: 23x23
#1272 @ 774,513: 11x17
#1273 @ 258,738: 19x10
#1274 @ 161,356: 22x21
#1275 @ 808,829: 27x15
#1276 @ 28,653: 19x19
#1277 @ 853,747: 21x13
#1278 @ 600,627: 18x28
#1279 @ 592,912: 16x10
#1280 @ 133,722: 10x11
#1281 @ 106,939: 13x17
#1282 @ 68,251: 25x17
#1283 @ 315,769: 26x18
#1284 @ 250,365: 25x10
#1285 @ 37,579: 26x24
#1286 @ 122,411: 17x12
#1287 @ 225,373: 12x15
#1288 @ 444,587: 22x26
#1289 @ 163,489: 27x11
#1290 @ 460,8: 14x25
#1291 @ 935,853: 22x17
#1292 @ 255,953: 11x17
#1293 @ 826,327: 10x20
#1294 @ 953,245: 10x13
#1295 @ 698,208: 17x21
#1296 @ 748,189: 29x12
#1297 @ 441,309: 26x13
#1298 @ 666,500: 27x27
#1299 @ 39,296: 16x14
#1300 @ 463,261: 10x15
#1301 @ 106,745: 20x28
#1302 @ 153,946: 18x10
#1303 @ 185,833: 12x26
#1304 @ 15,135: 18x11
#1305 @ 83,436: 17x24
#1306 @ 296,333: 20x12
#1307 @ 874,615: 17x22
#1308 @ 118,543: 25x14
#1309 @ 607,531: 14x25
#1310 @ 694,399: 14x20
#1311 @ 61,247: 18x7
#1312 @ 363,947: 29x18
#1313 @ 837,451: 13x17
#1314 @ 293,470: 26x25
#1315 @ 27,436: 16x15
#1316 @ 724,398: 11x22
#1317 @ 192,867: 16x11
#1318 @ 958,58: 20x22
#1319 @ 621,512: 14x12
#1320 @ 39,498: 16x13
#1321 @ 859,793: 11x16
#1322 @ 863,529: 29x29
#1323 @ 180,869: 23x14
#1324 @ 593,134: 21x27
#1325 @ 833,448: 17x22
#1326 @ 83,812: 23x26
#1327 @ 938,630: 25x20
#1328 @ 877,513: 13x25
#1329 @ 301,317: 29x12
#1330 @ 931,951: 24x27
#1331 @ 519,689: 24x18
#1332 @ 165,449: 21x20
#1333 @ 855,362: 27x10
#1334 @ 647,348: 10x27
#1335 @ 31,139: 17x24
#1336 @ 219,960: 26x15
#1337 @ 358,597: 15x22
#1338 @ 277,504: 21x27
#1339 @ 610,782: 28x10
#1340 @ 548,940: 18x10
#1341 @ 3,669: 18x17
#1342 @ 832,502: 22x24
#1343 @ 374,368: 25x18
#1344 @ 381,97: 14x24
#1345 @ 641,183: 29x24
#1346 @ 974,913: 25x15
#1347 @ 756,136: 26x24
#1348 @ 390,965: 27x15
#1349 @ 747,716: 17x16
#1350 @ 363,222: 13x25
#1351 @ 596,74: 17x19
#1352 @ 178,384: 27x27
#1353 @ 956,241: 26x20
#1354 @ 846,48: 16x15
#1355 @ 746,88: 29x14
#1356 @ 402,878: 21x11
#1357 @ 319,9: 28x23
#1358 @ 467,748: 21x17
#1359 @ 532,942: 12x14
#1360 @ 581,613: 19x14
#1361 @ 341,658: 22x29
#1362 @ 483,657: 10x13
#1363 @ 183,18: 18x13
#1364 @ 208,425: 12x27
#1365 @ 242,587: 25x18
#1366 @ 853,843: 15x17
#1367 @ 423,675: 6x3
#1368 @ 889,642: 16x23
#1369 @ 327,101: 13x19
#1370 @ 983,436: 14x20
#1371 @ 515,738: 16x18
#1372 @ 825,940: 24x24
#1373 @ 340,637: 20x19
#1374 @ 432,604: 21x24
#1375 @ 952,953: 21x25
#1376 @ 92,714: 23x20
#1377 @ 330,713: 16x11
#1378 @ 62,49: 13x23
#1379 @ 426,770: 23x26
#1380 @ 920,908: 14x18
#1381 @ 229,393: 18x11
#1382 @ 762,237: 24x29
#1383 @ 186,911: 22x25
#1384 @ 942,297: 26x18
#1385 @ 499,622: 18x15
#1386 @ 787,183: 13x25
#1387 @ 691,669: 21x16
#1388 @ 409,150: 28x23
#1389 @ 750,475: 15x25
#1390 @ 859,426: 19x22
#1391 @ 119,742: 22x13
#1392 @ 233,31: 16x15
#1393 @ 282,168: 22x21
#1394 @ 303,431: 17x20
#1395 @ 640,734: 14x19
#1396 @ 686,598: 10x28
#1397 @ 587,737: 19x17
#1398 @ 952,261: 13x10
#1399 @ 954,32: 23x19
#1400 @ 632,767: 10x21
#1401 @ 1,783: 21x20
#1402 @ 68,407: 19x14
#1403 @ 765,597: 26x15
#1404 @ 741,266: 19x17
#1405 @ 391,428: 11x10
#1406 @ 607,907: 13x16
#1407 @ 195,160: 22x22
#1408 @ 469,952: 9x13
#1409 @ 280,194: 13x20
#1410 @ 870,757: 18x13
#1411 @ 120,917: 19x14";

            var fabric = new Fabric();
            var result1 = fabric.ProcessClaims(input);
            var result2 = fabric.FindNoneOverlappingClaimId(input);

            Console.WriteLine("Day 3 part 1 result: " + result1);
            Console.WriteLine("Day 3 part 2 result: " + result2);
        }

        private static void Day2()
        {
            var checksumGenerator = new RudimentaryChecksumGenerator();

            var input = @"qysdgimlcaghpfozuwejmhrbvx
qysdtiklcagnpfhzuwbjmhrtvx
qysdtiflcsgnpfozuwejmhruvx
qkshtiklnagnpfozuwejmhrbvx
qysdtnklcagnpmozuwejmhrrvx
qysdttkecagnpfozuwijmhrbvx
qyedtiklcagnvfozuweymhrbvx
qyzdtikzcagnpfozuwejmhqbvx
qysdtiklcagnpfozlwedmhqbvx
qjsdtiklcagnpfozubejmhrbvq
qysdtiklcagnpfozvvejmhrbex
qdsdziklcagnpfouuwejmhrbvx
qysttikqccgnpfozuwejmhrbvx
qysdtiklcagnpbozwwecmhrbvx
qysdtiklcagnpfozuwexmmrjvx
nysdtiklcqgjpfozuwejmhrbvx
cysdoiqlcagnpfozuwejmhrbvx
qysdthxlcagnpfozuwejmcrbvx
qyswtiklcrgnpfozuwejmhrbvf
qysdtiklcagnpfozurejmhvpvx
qysdtiklcegnpfdzuwejghrbvx
qysdtjkluagnpfozuwenmhrbvx
qysdtimlcagnpjwzuwejmhrbvx
qyrdtiklcegnpeozuwejmhrbvx
qysdmiklcagnpfokswejmhrbvx
qysdtizlcagnpiozuwecmhrbvx
qysdtiklcignafxzuwejmhrbvx
qycdjiklcagnpzozuwejmhrbvx
qysdtiklcagnpjozuwepihrbvx
qyedtiklcrgnpfozuvejmhrbvx
mysdtikrcagnpfozwwejmhrbvx
qysdtiklcagnpfozuhcjmhrbsx
qmsdtiklcagnpfozuwehmhrevx
qgsdtiklcagnpfozuwejvhrbvp
lysdtikleagnpfozuwejmhrnvx
qxsdtivlzagnpfozuwejmhrbvx
qysdtiklcoggpfozuwebmhrbvx
wysdtiklcagnpfozuwejmornvx
jysdtiklvagntfozuwejmhrbvx
qmsdtiklcagnpfozuwejmrrbax
qysdttklcagnpfoiuwejmhrbvh
qysdtnklcaenpfozupejmhrbvx
qysdtoklcagnpfozuwexmhrbvq
qysdtiklcagnpuoeuwejmhrjvx
iysdtitncagnpfozuwejmhrbvx
qysdtixrcagnprozuwejmhrbvx
qyfdtiplcagnpfouuwejmhrbvx
qysdtmklcagnpfowuwejmhrbox
qysdtiklcagnxiozuwejphrbvx
fysdtiklcagnptozuwejmhrbvo
qysdqiklcagnplozuwejmhmbvx
qysdtwkacagnpfosuwejmhrbvx
qysdtitlcagnpfozufajmhrbvx
qysdtcklcagopfdzuwejmhrbvx
qmfdtdklcagnpfozuwejmhrbvx
qysztiklcaonpfozuwejmhrbfx
qygdtiklcggnpfozuwejmhrhvx
qysdiiklcagnpfozukejmcrbvx
qysdtrkloagnpfozuwujmhrbvx
qycdtiklcagnpfozywejmhrlvx
qgsdtikdcagnpfozgwejmhrbvx
qyudtikleagvpfozuwejmhrbvx
pysdtiqlcagnpfozuwejmarbvx
qysdtiklcaenpfozuwehahrbvx
qhsttiklcagnpfovuwejmhrbvx
zysdtikqmagnpfozuwejmhrbvx
rysdtikacagnpfozuwevmhrbvx
zysntikllagnpfozuwejmhrbvx
qysttimlcagndfozuwejmhrbvx
qysdtiklcaxopfqzuwejmhrbvx
qysdtislcagnpfozuwejmtrbnx
qysdviklcagnpfozswejmhibvx
qmsdtiklrygnpfozuwejmhrbvx
qysztiklcagnpfozuwejmorbrx
xysdtiklcagnzwozuwejmhrbvx
qysjthklcagnpfozowejmhrbvx
qysdtiklcagnpfofxwemmhrbvx
jysdtiklcagnpfozfwehmhrbvx
qysdtgklaagnpfozhwejmhrbvx
qqsdtiklcaenpfozuwejmhrvvx
qysdtikloajppfozuwejmhrbvx
qysdtiklcagnpwozuwejmhrhsx
qpsdtiklcapnprozuwejmhrbvx
qyzdtiklcagnpcozuwejmhrbvc
qusdhiklcagnpfozuwejmhrbxx
qysdtiklcagnpfozqwejthrvvx
qysvtiklcagnpfoiuwedmhrbvx
qgsdtiklcagvpfozuwejmhrbvf
qysdtikxcawnpfozuwejmarbvx
qyvctiklcaynpfozuwejmhrbvx
qyyltiklnagnpfozuwejmhrbvx
oysdtillcagnpfozuwejmnrbvx
qysdtiklcagnpfozuvmjmhrbzx
qykdtikocagnpfhzuwejmhrbvx
qysdtvkloagnpfozuwejmkrbvx
qysetiklcagnpfozuwejmhrxvh
qysdtiklcavnpfuzuwejmhrbvh
qmndtiklcagnpfojuwejmhrbvx
qysdtialcagnpfozuwejmdrqvx
qysdtiklcagnpfozuwejtzrbvv
qysdtiklxagnpyozufejmhrbvx
qysdtiklcagnpfgzewejahrbvx
qysdtiklcagppsozuwejmhrdvx
qykdtiklcainpfozuwejqhrbvx
qysdtiklcagnpfszxwejmhubvx
qyrdtiklcagkptozuwejmhrbvx
qysdsiklcagnpfozsvejmhrbvx
qypdtiklcagypfozuwejmhrlvx
qssdtiklcagnpfozuwqjmirbvx
qyshtiklcagnpfrzuwyjmhrbvx
qysdtiklcagnpfqzuwenmgrbvx
qysdtiklcagnpfonuwejmhkwvx
qysdhiklcagnpfokuwejmhrfvx
jysrtiklcaenpfozuwejmhrbvx
qysdtiilcagnpfozuwejmhcbvl
qysdtiklcagnheozuwejmhrbvn
qysdtikucagwpfojuwejmhrbvx
qysdtinlctgnpfozuwujmhrbvx
qysdtiklcagnpiozuwejmtrbjx
qysktiklcagqpfozuwcjmhrbvx
qysddiklcagnpfozpwejmhrbvh
wysdtiplcagnpfozuwejyhrbvx
qysdtiklcagnpfjzlwejmhrcvx
qysdtikleagopbozuwejmhrbvx
qysdtqklcwgnpfozuwejmirbvx
qysdtiklcugnpmozuwejmhrbvp
qysdtiklcagnpfozpwejmnrbvz
qysdtiklcagnpcozuwejmhbbmx
uysitiklcagnpfozewejmhrbvx
qykdtiklcasnpfozuwejdhrbvx
qyjdtiklcagnpqozuzejmhrbvx
qysdtiklcagaifozuwejmhrbvh
qysdtiklcagnhfozuwyjrhrbvx
qysetiklcaanpfozuwyjmhrbvx
qyfdtiklcagnphozulejmhrbvx
qysdtikkcrgnpfozuwejmhpbvx
qysdtiklcarnpfdzuwejmhrbvq
qysdtiklcfyrpfozuwejmhrbvx
rysdtitlcagnpfoznwejmhrbvx
qysdtiilcagnffozugejmhrbvx
qysdyifloagnpfozuwejmhrbvx
qysdtiklcegnpfozuwejmlrcvx
qysdtiklcagnpfozuwajmhbbqx
qysptrklcarnpfozuwejmhrbvx
qysdtiklcagnldozuwejmhwbvx
qysdtiklczgqpfozuwejmhobvx
qyxdtiklcagcpfoiuwejmhrbvx
qysatiklczgnpfozawejmhrbvx
qysduiklcagnpfoziwejyhrbvx
qysdtgklqagnpfozujejmhrbvx
qysdtiqlcagnpfozzdejmhrbvx
qysdtiklcngnpfofuwejmzrbvx
qysdtiklcagnyfozuwejrnrbvx
qysdtiplcagnpfozowmjmhrbvx
qyswtiklcagnplozuwedmhrbvx
qyseiiklcagnpfozuwejmhibvx
qysdtiklcagnpfozutusmhrbvx
qysdtimlcagnpfozccejmhrbvx
qnsdniklcagnpfobuwejmhrbvx
qysrtiklcagnpfofuwejmhrbyx
qyzdtiklcagnpfoizwejmhrbvx
qysdtjslcdgnpfozuwejmhrbvx
qysdtiklcagnpxoyuwejmrrbvx
qysdtikllagnpfmzuwbjmhrbvx
qysdtitlcagnkfozuwejwhrbvx
qymdtiklcggnpfozuwejmzrbvx
qysdtiklclfnpfozuhejmhrbvx
qysdtyklcagnpfozuwejmhhbix
qysetiklcagnpfozuwejmhrspx
qysdipklcagnpfozuwejmhrbex
uysgtiklcagnpmozuwejmhrbvx
qysdtiklmagnpfozuwqlmhrbvx
qysdtiklcagnyfozxwejmhrmvx
qysutillcagnpfozuwejmhrbbx
casdtiklcagnpfopuwejmhrbvx
qesdtiklctgnpfmzuwejmhrbvx
qysdtiklcagopfozjwejmdrbvx
jzsdtiklcagnpfozuwejmurbvx
qysdtiklcjgnpfonuwejrhrbvx
qysdtiklcrgnpnozuwejmhqbvx
oyhdtiklcagnpfozuwekmhrbvx
qysstiklcagjpfozuwejmhrbnx
qyudtiklsagnpsozuwejmhrbvx
qysdtiilcagnpfozusejmhrbva
qysdtiklcaknpfozmwejmhgbvx
qysdbiklcpgnpfozuwejmrrbvx
qybdtiklcagvpfokuwejmhrbvx
qysatiklcagnpwofuwejmhrbvx
qysdtiklcadnpfonuwejmcrbvx
qysdtijfcagnpfozuvejmhrbvx
qysdtiklcagnpfhluuejmhrbvx
qysdtiklcagnpfoguwejqhrwvx
qlsdtiklcagnpfojuwehmhrbvx
qyhdtiolcagnpfozuwejmhrzvx
qmsdtiklcagnppozuwpjmhrbvx
qysdtiklvvgnpfvzuwejmhrbvx
qysdtiklcagnpfszuwajmhrcvx
qysdtiklcagnpfmzuwekmhrbyx
qysdtiklcagwpfozumevmhrbvx
qysdtaklcagnpfozuwejvhzbvx
qysotiklcagntffzuwejmhrbvx
qysdtiklcagnpfowuweqmhrivx
qysdtrkloagnxfozuwujmhrbvx
qasdiiklcagnpfozuwegmhrbvx
qysbtiklcagnpfozuwejthrbhx
hysdtikllagnpfozuwejmhrbbx
qyqdtiklcagnpsozuwejmcrbvx
qysdtiklcagnpiqzuwejmhrbux
qnsdtiklcagnpfozdwejmhbbvx
qysjbiklcagzpfozuwejmhrbvx
qysdtiklcagnpfifuwejmhrbvg
qysdtiklcaggpkozunejmhrbvx
qxsdtiklcavnpfozuwfjmhrbvx
qysdtikycabnpfkzuwejmhrbvx
qyswtzklcagnpfozuwejmhrlvx
qysdtikqcagnpfozuwejrhnbvx
qysdtiplaagnpfozuwejmhruvx
qjcdtiklcagnpfozujejmhrbvx
nysdtyklcagnpfozutejmhrbvx
qysrtiklcagnpfnzuwejmhrbdx
zysdtielcagnpfozuwezmhrbvx
qysdtikpvagnpfozuzejmhrbvx
qysdwiklcagnpfozueejmhrlvx
dysdmiklcagnpfozuwejzhrbvx
qysdtiklcjgnpfozuweimhmbvx
qysdtiklciynpyozuwejmhrbvx
qksdtiklcagnpbozubejmhrbvx
qysdtiklkagnpfozuwejmhrjvb
yyxdtiklcagnpfomuwejmhrbvx
qysdtiklcagnfnozuwejmhrbvv
qysdtzklcagnpfozuwejmhrmvb
qysduiklclgnpfozuwejmhrbvn
qyndtmklcavnpfozuwejmhrbvx
qisdkiklcagnpfozuwqjmhrbvx
qysdtrkycagypfozuwejmhrbvx
qhsdtiklcwgnmfozuwejmhrbvx
qysdaiklcannpfozupejmhrbvx
zysdtiklcagnpjozuwejmhrbwx
qysdtikxcagnpfozuwejmcrxvx
qysdtzklcagnpfozewejmhrbvk
qysdwtklcagnhfozuwejmhrbvx
qysdtqklcaenpfozuwejmdrbvx
qysdtiklcagnpfozuoeemhqbvx
nysdtikocagnpfozuwejmhwbvx
qysxtiklcagnpfozqwejmhrbax
qysdtielcasnpfozuwejmhsbvx
qysdtiklcaknpfozuwejcwrbvx
qysytiklcagnpfozdfejmhrbvx
qysdtiklcagmpfozuwejmgrbox
qysdtielcagnpfpzuwejhhrbvx";

            var checksum = checksumGenerator.Generate(input);

            var boxIdFinder = new BoxIdFinder();
            var mostCommonLetters = boxIdFinder.GetMostCommonLetters(input);

            Console.WriteLine("Day 2 part 1 result: " + checksum);
            Console.WriteLine("Day 2 part 2 result: " + mostCommonLetters);

        }

        private static void Day1()
        {
            var chronalCalibration = new ChronalCalibration();

            string input = @"-16
+12
-6
-16
+4
+19
-10
+20
-16
-6
+3
-12
-7
+6
-12
-7
-15
-2
+11
+5
+5
-9
-14
-3
-4
+16
+11
+7
+17
-4
+17
+1
-9
-6
-14
-8
+3
-13
+14
-8
-5
+16
+18
-4
+10
+16
-4
+9
+14
+8
-19
-11
+19
-13
+8
-4
-6
-7
+4
+6
+6
+7
+6
-3
+10
+13
-19
+5
+8
+16
+3
+11
+7
+2
+8
+5
-8
+10
+6
-2
-16
-9
-1
-11
-12
-8
+17
-16
-5
+16
-9
+13
+3
+6
-16
+4
-6
-19
+5
-6
+7
+8
+20
-1
+6
-3
+16
-17
+10
+1
+20
-15
+13
+10
+15
-9
+6
+11
+14
+8
-3
+5
-14
+2
-14
-19
+1
-5
+1
+18
+1
-13
+11
+10
-19
-13
+7
-16
-5
+13
+16
+18
-2
+6
-11
+9
+11
+6
-7
-17
-18
+6
+3
+19
+20
+4
+15
+11
-13
+12
-7
+10
-5
-14
-16
+11
+10
+2
+13
+7
+9
-18
-5
-17
+14
+16
-3
+9
+6
-17
+16
+6
+14
+12
+11
+7
+17
+11
-15
+8
+17
+17
+2
-15
-16
+15
+15
-2
+16
-10
+2
+5
-16
+8
-19
+5
-2
+7
-16
+10
-9
-11
+13
+11
+4
-3
+15
-1
+10
+18
-4
-1
-12
+6
+15
-3
-17
+3
+21
+2
-18
-15
-21
-16
+5
-20
+7
-5
-16
+18
-19
+14
+10
-19
-15
-14
+13
-15
+6
-13
+17
+4
+15
-7
-13
+21
+17
-8
-4
+9
-11
+4
-1
-15
-20
-14
-9
-11
-17
-11
-12
-4
+3
-10
-13
+18
-14
+10
+18
+6
-13
+9
-1
-4
+8
+6
+25
-11
-11
+19
+15
+15
-2
-16
+11
+8
-13
-4
-5
+2
+5
+20
-14
-18
+17
-4
+12
+8
-11
+17
+13
+8
-19
-1
+11
+29
+5
+26
+14
-1
+10
-16
+11
+12
-4
-15
-16
+32
-8
+5
+12
-4
+21
-7
-7
-31
-5
-15
-16
+9
-36
-11
-25
+16
+12
+14
-72
+7
+4
+15
+15
+16
+39
+73
+20
-14
+6
+13
-2
+1
-28
+75
-14
+15
+8
-10
-3
-16
-6
-19
-5
-24
-24
+106
+14
-2
+19
-8
-16
-13
+33
+20
-2
-2
+24
-2
-11
+8
+4
+9
+32
-9
+19
-2
-22
-6
+50
-17
+10
+6
+23
+10
+3
+88
+112
+11
+18
+12
+55
+9
+29
+13
-88
+6
+423
+55676
+1
-8
-16
-16
+19
+7
-5
+4
-3
-16
+9
+3
-7
-10
-8
-3
-4
+8
-7
-15
+2
-1
+8
+3
+4
-3
+13
-19
-15
-11
+10
+3
-9
-19
-1
-4
+19
+13
-10
+14
+9
+14
+15
-8
-24
-15
+11
-1
-16
-15
-4
-18
-5
+10
-8
-3
+2
+13
+14
+7
+12
-9
+17
-9
-9
-21
+6
+17
-24
-6
+10
+13
-20
-15
-14
-11
-3
-8
-1
+15
+9
-17
-18
+4
+6
-11
-19
-7
+18
-4
-12
-5
-18
-3
+10
-4
-10
-11
+6
+11
+6
+8
+12
+8
-1
+19
+14
-1
-3
+19
-5
+15
+3
+1
+22
-19
-8
-2
-9
+13
+1
-7
+18
+16
+4
+6
+19
-18
+2
+3
+34
-14
+8
+7
+12
+9
-15
+24
+7
+11
-4
-13
+16
+7
-13
-15
-12
+20
+21
-4
+21
+19
+19
+10
-7
-9
+11
-6
+5
+5
-13
-17
+8
+4
-13
-8
+14
+11
+7
-9
-17
-3
-5
-16
+9
-2
-8
-3
+10
+16
+18
+5
+15
+14
+2
+15
-8
+1
+15
+11
+18
-5
+3
-13
-9
-19
+15
-7
-14
-18
+12
-1
+16
-8
+9
+16
+20
-16
+11
+1
+14
-16
-4
+3
+14
+10
+12
-16
-4
+14
-19
-12
-20
+17
-16
-6
+15
-20
-16
-17
+10
+13
-14
+18
-6
+3
-10
-3
+4
+13
-16
-7
+31
+11
+1
+1
+13
-5
-5
+21
+18
+20
-9
-3
-9
-11
+8
-1
-4
+14
+14
-15
-6
+14
+1
+2
+14
+21
+8
-15
+20
-10
-20
-5
-10
-17
-15
+16
-8
+16
+15
+12
+11
-3
+21
-17
+6
-15
+1
-19
+8
+21
-16
-19
+8
+7
-8
+3
-20
-39
-18
+14
-12
-29
+3
-14
-10
-9
-3
-22
-8
+1
+3
-5
-1
-19
-25
+9
-7
-14
+19
+19
-27
-6
+27
+10
+29
+19
-23
+17
-10
+5
+13
-15
-25
+13
+3
+14
-37
+6
+18
+18
+89
+57
-17
+39
-2
+27
+13
-18
-17
+9
+1
+14
-4
+10
-19
+18
+7
+13
+8
+7
+11
-7
-9
-3
-4
+9
+24
-3
-16
-23
+7
-16
-1
-15
-12
+19
-2
+14
-21
-2
-12
-14
-62
+22
+7
+66
+26
-21
+61
+5
-6
+11
-7
+18
+67
+38
+18
+30
-18
-120
+24
-18
-16
+31
-102
+11
+149
+96
+9
-40
+69
+13
+757
+55505
+6
+11
+13
-16
+14
-13
-2
-14
-19
+18
-14
-18
+1
+11
+19
-6
-2
-13
+3
-14
-2
+6
+4
+4
-18
+16
-13
-16
+8
+10
-9
+1
-19
+14
-15
-10
+8
-10
-18
-3
-7
+3
+2
+10
-18
-2
-18
+17
-13
-9
+16
-3
-19
-7
-6
-10
+6
-12
+17
-18
+11
+5
-2
-4
-15
-2
-19
-9
+15
-4
-17
+16
+17
+13
-7
-9
+10
-5
-11
+4
-16
-19
-13
-8
-8
+18
-6
+19
+2
+16
-11
+18
+3
-14
+2
+7
+19
-8
+24
-9
+17
+9
+10
-8
-4
-8
+24
+19
-6
+4
+13
+4
+18
-8
+12
-17
-17
-2
-17
-11
-2
+5
-6
+2
+8
-5
-16
-17
+5
-1
-6
-12
-9
-14
-17
+5
-2
-17
-11
+9
-12
+4
-8
+2
+9
+18
+19
+20
-23
-5
+6
+21
+12
+28
+23
-4
+10
+16
+15
+6
+9
-10
-1
+18
-21
-10
+20
-15
-9
+21
+5
-15
-15
+12
+29
-12
+21
-2
-8
+4
+5
-11
+19
-14
-113326";

            var result1 = chronalCalibration.CalculatePart1(input);
            var result2 = chronalCalibration.CalculatePart2(input);

            Console.WriteLine("Day 1 part 1 result: " + result1);
            Console.WriteLine("Day 1 part 2 result: " + result2);
        }
    }
}
