﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace huffman {
    class Program {
        static void Main(string[] args) {
            Console.Title = "Huffman Code";
            string text = "" +
@"I've got another confession to make
I'm your fool
Everyone's got their chains to break
Holdin' you
Were you born to resist or be abused?
Is someone getting the best, the best, the best, the best of you?
Is someone getting the best, the best, the best, the best of you?
Are you gone and onto someone new?
I needed somewhere to hang my head
Without your noose
You gave me something that I didn't have
But had no use
I was too weak to give in
Too strong to lose
My heart is under arrest again
But I break loose
My head is giving me life or death
But I can't choose
I swear I'll never give in
I refuse
Has someone taken your faith?
Its real, the pain you feel
You trust, you must
Confess
Is someone getting the best, the best, the best, the best of you?
Has someone taken your faith?
Its real, the pain you feel
The life, the love
You die to heal
The hope that starts
The broken hearts
You trust, you must
Confess
Is someone getting the best, the best, the best, the best of you?
Is someone getting the best, the best, the best, the best of you?
I've got another confession my friend
I'm no fool
I'm getting tired of starting again
Somewhere new
Were you born to resist or be abused?
I swear I'll never give in
I refuse
Has someone taken your faith?
Its real, the pain you feel
You trust, you must
Confess
Is someone getting the best, the best, the best, the best of you?";
            HuffmanTree tree = HuffmanTree.CreateFromText(text);
            byte[] encoded = tree.Encode(text);

            Console.WriteLine("text size: " + (text.Length * 8) + " bytes");
            Console.WriteLine("encoded size: " + (encoded.Length * 8) + " bytes");

            string decoded = tree.Decode(encoded);
            Console.WriteLine(decoded);
            
            
            Console.WriteLine("IT DONE");
            Thread.Sleep(-1);
        }
    }
}