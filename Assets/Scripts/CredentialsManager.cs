using System;
using UnityEngine;
using Amazon;
using Amazon.CognitoIdentity;


public class CredentialsManager
{

    // Region - A game may need multiple region endpoints if services
    // are in multiple regions or different per service
    public static RegionEndpoint region = RegionEndpoint.USEast1; //change this if you are in a different region

    // Cognito Credentials Variables
    public const string identityPool = "identity-pool-id-here";
    public static string userPoolId = "user-pool-id-here";
    public static string appClientId = "app-client-id-here";

    // Initialize the Amazon Cognito credentials provider
    public static CognitoAWSCredentials credentials = new CognitoAWSCredentials(
        identityPool, region
    );

    // User's Cognito ID once logged in becomes set here
    public static string userid = "";

}
