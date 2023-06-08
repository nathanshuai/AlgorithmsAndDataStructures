//Using Stacks and Queues where appropriate, create a simple command line playlist app
//that allows a user to add a song to a playlist. Provide commands to play the next song,
//skip the upcoming song, or add a new song to the playlist. Users should be able to
//rewind by one song many times to play a previous track.

using System;
using System.Collections.Generic;




Queue<string> playlist = new Queue<string>();
string nextSong = "";
bool showExitOption = true;

bool exit = false;
while (!exit)
{
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1. Add a song to your playlist");
    Console.WriteLine("2. Play the next song in your playlist");
    Console.WriteLine("3. Skip the next song");
    Console.WriteLine("4. Rewind one song");
    if (showExitOption)
    {
        Console.WriteLine("5. Exit");
    }

    int option = int.Parse(Console.ReadLine());

    if (option == 1)
    {
        Console.WriteLine("Enter Song Name:");
        string songName = Console.ReadLine();
        playlist.Enqueue(songName);
        Console.WriteLine($"\"{songName}\" added to your playlist.");
        if (nextSong == "")
        {
            nextSong = songName;
        }
        Console.WriteLine($"Next song: \"{nextSong}\"");
        showExitOption = false;
    }
    else if (option == 2)
    {
        if (playlist.Count > 0)
        {
            string currentSong = playlist.Dequeue();
            Console.WriteLine($"Now playing \"{currentSong}\"");
            showExitOption = false;
            if (playlist.Count > 0)
            {
                nextSong = playlist.Peek();
                Console.WriteLine($"Next song: \"{nextSong}\"");
            }
            else
            {
                Console.WriteLine("Next song: none queued");
                nextSong = "";
            }
        }
        else
        {
            Console.WriteLine("Your playlist is empty.");
        }
    }
    else if (option == 3)
    {
        if (playlist.Count > 0)
        {
            playlist.Dequeue();
            Console.WriteLine("Skipped the next song.");
            showExitOption = false;
            if (playlist.Count > 0)
            {
                nextSong = playlist.Peek();
                Console.WriteLine($"Next song: \"{nextSong}\"");
            }
            else
            {
                Console.WriteLine("Next song: none queued");
                nextSong = "";
            }
        }
        else
        {
            Console.WriteLine("Your playlist is empty.");
        }
    }
    else if (option == 4)
    {
        if (playlist.Count > 0)
        {
            string currentSong = playlist.Dequeue();
            Console.WriteLine($"Rewound to the previous song: \"{currentSong}\"");
            playlist.Enqueue(currentSong);
            showExitOption = false;
            if (playlist.Count > 0)
            {
                nextSong = playlist.Peek();
                Console.WriteLine($"Next song: \"{nextSong}\"");
            }
            else
            {
                Console.WriteLine("Next song: none queued");
                nextSong = "";
            }
        }
        else
        {
            Console.WriteLine("No previous song to rewind to.");
        }
    }
    else if (option == 5)
    {
        exit = true;
    }
    else
    {
        Console.WriteLine("Invalid option. Please try again.");
    }

    Console.WriteLine();
}





