using System;

class Program
{
    static void Main(string[] args)
    {   
        // ================================== Breathing Activity Instance ==================================
        string breathingName1 = "Breathing Activity";
        string breathingDescription1 = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        int breathingDuration1 = 5000;
        BreathingActivity breathingActivity1 = new BreathingActivity(breathingName1, breathingDescription1, breathingDuration1);
        
        
        
        
        // ================================== Listing Activity Instance ==================================
        string listingName1 = "Listing Activity";
        string listingDescription1 = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        int listingDuration1 = 5000;
        int listingCount = 5;
        List<string> listingPrompts = new List<string>();
        ListingActivity listingActivity1 = new ListingActivity(listingName1, listingDescription1, listingDuration1, listingCount, listingPrompts);
        
        
        
        
        // ================================== Reflecting Activity Instance ==================================
        string reflectingName1 = "Reflecting Activity";
        string reflectingDescription1 = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        int reflectingDuration1 = 5000;
        List<string> reflectingPrompts = new List<string>();
        List<string> reflectingQuestions = new List<string>();
        ReflectingActivity reflectingActivity1 = new ReflectingActivity(reflectingName1, reflectingDescription1, reflectingDuration1, reflectingPrompts, reflectingQuestions);
    }
}