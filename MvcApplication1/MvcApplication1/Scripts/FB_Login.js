<script
src="scripts/jquery-1.8.0.min.js"
type="text/javascript"></script> <script
src="scripts/all.js"
type="text/javascript"></script> 7) Now to initialize the Facebook SDK copy following code in a new script section :
         $("document").ready(function () {
            // Initialize the SDK upon load
            FB.init({
                appId: 'YOUR_APP_ID', // App ID
                channelUrl: '//' + window.location.hostname + '/channel', // Path to your Channel File
                scope: 'id,name,gender,user_birthday,email', // This to get the user details back from Facebook
                status: true, // check login status
                cookie: true, // enable cookies to allow the server to access the session
                xfbml: true  // parse XFBML
            });
            // listen for and handle auth.statusChange events
            FB.Event.subscribe('auth.statusChange', OnLogin);
        });