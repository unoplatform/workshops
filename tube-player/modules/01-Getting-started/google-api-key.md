---
uid: Workshop.TubePlayer.GetStarted.ApiKey
---

<details>
    <summary>Detailed instructions on obtaining a YouTube API key</summary>

### Create a new project in Google Console

1. Open the [Enabled APIs and services](https://console.cloud.google.com/apis/dashboard) page in the Google Console Dashboard.

    If this is the first time you're using Google Console, you might see a message similar to this one:

    ![Google Console getting started popup](google-console-01-getting-started.jpg)

    Agree to the terms of service.

1. On the top of the page, click the projects dropdown:

    ![Google Console project selector dropdown](google-console-02-select-project.jpg)

1. Then, on the popup that opens, click *New project*:

    ![Google Console new project button](google-console-03-new-project.jpg)

1. Give the project a descriptive title, such as *Uno Tube Player*, and click *Create*.  
    The project will now be created and selected in the top dropdown.

    ![Google Console new project selected](google-console-04-project-selected.jpg)

    If you can't see the project, try refreshing the page.

### Enable YouTube APIs for this project

1. If you are not already, navigate back to the *Enabled APIs and services page*, and click *Enable APIs and services*

    ![Google Console Enabled APIs and services menu item](google-console-05-enabled-apis.jpg)

1. From the APIs page, click *YouTube Data API v3* (you can search for it):

    ![Google Console YouTube Data API v3 menu item](google-console-06-youtube-api.jpg)

1. Click *Enable*

    ![Google Console Enable API button](google-console-07-enable-api.jpg)

### Obtain an API key

1. Once YouTube Data API v3 has been enabled, [its page](https://console.cloud.google.com/apis/api/youtube.googleapis.com) will open.

    ![Google Console create credentials button](google-console-08-create-credentials.jpg)

1. Click *Create credentials* and select *Public data*, then click *Next*.

    ![Google Console API key configuration page](google-console-09-public-data.jpg)

1. The API key will be revealed to you, click the copy button and copy the API key somewhere safe and private, it will be used in [Module 8 - API endpoints](xref:Workshop.TubePlayer.ApiEndpoints) when searching YouTube's data.

    ![Google Console copy API key](google-console-10-copy-api-key.jpg)

    Alternatively, keep this tab open to copy the API key later.

1. You can always access the API key via the credentials menu on the left side.

    ![Google Console copy API key](google-console-11-credentials-page.jpg)

</details>