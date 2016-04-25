# Project RoundhousE #
### "Professional Database Versioning and Change Management" ###
RoundhousE is an automated database deployment (change management) system that allows you to use your current idioms and gain much more.

It seeks to solve both maintenance concerns and ease of deployment. We follow some of the same idioms as other database management systems (SQL scripts), but we are different in that we think about future maintenance concerns. We want to always apply certain scripts (anything stateless like functions, views, stored procedures, and permissions), so we don’t have to throw everything into our change scripts. This seeks to solves future source control concerns. How sweet is it when you can version the database according to your current source control version?

**DOCUMENTATION?** Have a look here: https://github.com/chucknorris/roundhouse/wiki

## Important ##
RoundhousE is a dual repository (svn and git). You can find the git repository at (https://github.com/chucknorris/roundhouse)


**Donations Accepted** - If you enjoy using this product or it has saved you time and money in some way, please consider making a <a href='https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=9831498'>donation</a>. It helps keep to the product updated, pays for site hosting, etc. The link is the donate button on the right or click <a href='https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=9831498'>here</a>.

<a title='logo'>
<img src='http://roundhouse.googlecode.com/svn/trunk/docs/logo/RoundhousE_Logo.jpg' alt="RoundhousE. It's not for the faint of heart." width='318' height='300' />

<h2>Get RoundhousE</h2>
<h3>Downloads</h3>
<ul><li>You can download RoundhousE from <a href='http://code.google.com/p/roundhouse/downloads/list'>http://code.google.com/p/roundhouse/downloads/list</a>
</li><li>You can also obtain a copy from the build server at <a href='http://teamcity.codebetter.com'>http://teamcity.codebetter.com</a></li></ul>

<h3>NuGet</h3>
With <a href='http://nuget.codeplex.com'>NuGet</a> you can get the current release of RoundhousE to your application quickly!<br>
<br>
<ol><li>In Visual Studio Package Manager Console type <code>install-package roundhouse</code>
</li><li>RoundhousE NuGet packages available:<br>
<ul><li><a href='http://nuget.org/list/packages/roundhouse'>roundhouse</a>
</li><li><a href='http://nuget.org/list/packages/roundhouse.lib'>roundhouse.lib</a>
</li><li><a href='http://nuget.org/list/packages/roundhouse.msbuild'>roundhouse.msbuild</a>
</li><li><a href='http://nuget.org/list/packages/roundhouse.refreshdatabase'>roundhouse.refreshdatabase</a></li></ul></li></ol>

<h3>Chocolatey</h3>
<a href='http://nuget.org/list/packages/chocolatey'>Chocolatey</a> is like apt-get, but for Windows! This is an alternative method to get the current release of RoundhousE to your machine quickly!<br>
<br>
<ol><li>Type <code>cinst roundhouse</code>
</li><li>Then from anywhere you can type <code>rh [options]</code></li></ol>

<a title='roadmap' />
<h1>Roadmap</h1>
<h2>v1</h2>
<ul><li><del>Create logo</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=54'>revision 54</a>)<br>
</li><li><del>Create non-existent database</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=13'>revision 13</a>)<br>
</li><li><del>Run sql in order based on file names</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=17'>revision 17</a>)<br>
<ul><li><del>0001_Create.sql comes before 0002_Insert.sql</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=17'>revision 17</a>)<br>
</li></ul></li><li><del>Run stateless SQL every time</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=17'>revision 17</a>)<br>
<ul><li><del>Stateless sql (functions, views, sprocs) stays out of the up and down sections so they can be properly maintained in their own files in source control</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=17'>revision 17</a>)<br>
</li></ul></li><li><del>Versioning</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=45'>revision 45</a>)<br>
<ul><li><del>Versioning the database based on an XML file that contains the version/revision.</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=45'>revision 45</a>)<br>
</li><li><del>Grab the version from a DLL's file version</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=32'>revision 32</a>)<br>
</li></ul></li><li><del>Track which files have run</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=23'>revision 23</a>)<br>
</li><li><del>Files that run in up/down should only run once</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=29'>revision 29</a>)<br>
</li><li><del>Restore a database from a known location</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=32'>revision 32</a>)<br>
</li><li><del>NAnt Task</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=11'>revision 11</a>)<br>
</li><li><del>MSBuild Task</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=11'>revision 11</a>)<br>
</li><li><del>Console</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=69'>revision 69</a>)<br>
</li><li><del>One way hash of script text - allows for updating person when script has already been run but has changed</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=58'>revision 58</a>)<br>
<ul><li><del>hashing</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=53'>revision 53</a>)<br>
</li><li><del>Notification and/or error on changes of text that has already run</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=58'>revision 58</a>)<br>
</li></ul></li><li><del>Create a change drop folder for recording all changes (items that actually run) (<a href='https://code.google.com/p/roundhouse/issues/detail?id=4'>issue 4</a>)</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=67'>revision 67</a>)<br>
</li><li>backup the database before running (<a href='https://code.google.com/p/roundhouse/issues/detail?id=3'>issue 3</a>)<br>
<ul><li>drop a restore.bat file next to the backup to run in case something goes awry<br>
</li><li>drop to change_drop folder<br>
</li></ul></li><li><del>Move datatabases to plug in model to make it easy to use sql 2005/2008 or something else</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=64'>revision 64</a>)<br>
</li><li><del>Add a switch for drop</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=73'>revision 73</a>)<br>
</li><li>Documentation<br>
<ul><li>Getting Started<br>
</li><li>Running RoundhousE<br>
</li></ul></li><li><del>Reports version (<a href='https://code.google.com/p/roundhouse/issues/detail?id=9'>issue 9</a>)</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=108'>revision 108</a>)</li></ul>

<h2>v2</h2>
<ul><li><del>Run only items that have changed since the last migration (Only run the stateless items when the hash has changed)</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=59'>revision 59</a>)<br>
</li><li>Permission changes for auditing (timestamp, .pre .post with version numbers of each)<br>
<ul><li>script permissions before<br>
</li><li>script permissions after<br>
</li></ul></li><li>change_drop folder changes<br>
<ul><li>security permission changes from above<br>
</li><li><del>change log added</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=81'>revision 81</a>)<br>
</li><li>change_drop folder is zipped up afterwards (DatabaseName-PriorVersion-NewVersion.zip) (<a href='https://code.google.com/p/roundhouse/issues/detail?id=5'>issue 5</a>)<br>
</li></ul></li><li>Use RoundhousE to set up migrations (<a href='https://code.google.com/p/roundhouse/issues/detail?id=2'>issue 2</a>)<br>
<ul><li><del>will compare two databases to create change scripts (actually will create a second Database based on current scripts to baseline and compare it against the current database in development to generate change scripts and regenerate objects)</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=197'>revision 197</a>) - Using RedGate - still working out the details though for making this available for use<br>
</li><li>will have a folder for all objects to check into source<br>
</li></ul></li><li><del>Run in a transaction</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=74'>revision 74</a>)<br>
</li><li>Create wiki page<br>
</li><li>Should we include indexes outside of the up/down folders?<br>
</li><li>rh.exe initialize folderName will create the database project and the required folders (<a href='https://code.google.com/p/roundhouse/issues/detail?id=6'>issue 6</a>).<br>
</li><li>GUI Interface (isn't that a little redundant?)<br>
</li><li>Web Interface for Web Installs<br>
</li><li><del>Environment aware for things like permissions and test data</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=86'>revision 86</a>)</li></ul>

<h2>Future version</h2>
<ul><li>Downgrade a database<br>
</li><li><del>RoundhousE needs it's own internal versioning scheme so it can upgrade itself (<a href='https://code.google.com/p/roundhouse/issues/detail?id=38'>issue 38</a>)</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=268'>revision 268</a>)<br>
</li><li>Metrics tracking on the runner<br>
</li><li>Other database types<br>
<ul><li><del>Oracle support (<a href='https://code.google.com/p/roundhouse/issues/detail?id=34'>issue 34</a>)</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=186'>revision 186</a>)<br>
</li><li>MySQL Support<br>
</li><li><del>MSAccess Support</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=96'>revision 96</a>)<br>
</li><li>others?</li></ul></li></ul>

<h2>Requested Enhancements</h2>
<ul><li><del>Can I use synonyms for database type? (<a href='https://code.google.com/p/roundhouse/issues/detail?id=10'>issue 10</a>)</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=85'>revision 85</a>)<br>
</li><li>Run a DLL with embedded SQL files (can get the version from that file) (<a href='https://code.google.com/p/roundhouse/issues/detail?id=27'>issue 27</a>)<br>
</li><li>Can I insert a bunch of test data automatically into a database for load testing?<br>
</li><li><del>Please interact with NHibernate (and FNH) to create schema files (<a href='https://code.google.com/p/roundhouse/issues/detail?id=11'>issue 11</a>)</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=299'>revision 299</a>)<br>
</li><li><del>Can I add custom Restore Arguments - like MOVE? (<a href='https://code.google.com/p/roundhouse/issues/detail?id=12'>issue 12</a>)</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=104'>revision 104</a>)<br>
</li><li><del>Split statements on GO in sql server types (<a href='https://code.google.com/p/roundhouse/issues/detail?id=17'>issue 17</a>)</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=113'>revision 113</a>, <a href='https://code.google.com/p/roundhouse/source/detail?r=125'>revision 125</a>)<br>
</li><li><del>Increase the restore timeout/make it configurable (<a href='https://code.google.com/p/roundhouse/issues/detail?id=21'>issue 21</a>)</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=117'>revision 117</a>)<br>
</li><li><del>Allow for Custom Create Database Scripts (<a href='https://code.google.com/p/roundhouse/issues/detail?id=20'>issue 20</a>)</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=116'>revision 116</a>)<br>
</li><li><del>Use Ado.NET instead of SMO (<a href='https://code.google.com/p/roundhouse/issues/detail?id=22'>issue 22</a>)</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=125'>revision 125</a>)<br>
</li><li><del>Add option not to create a database, even if it doesn't exist (<a href='https://code.google.com/p/roundhouse/issues/detail?id=24'>issue 24</a>)</del> - DONE (<a href='https://code.google.com/p/roundhouse/source/detail?r=123'>revision 123</a>)<br>
</li><li>Dry run or something similar (<a href='https://code.google.com/p/roundhouse/issues/detail?id=36'>issue 36</a>)<br>
</li><li>During restore for sql server, mdf and ldb files should be moved to the default location if one is not specified in the custom restore options (<a href='https://code.google.com/p/roundhouse/issues/detail?id=13'>issue 13</a>)</li></ul>

<a title='feedback' />
<h1>What others are saying</h1>

"This is, without a doubt, freaking awesome!" - Chris Patterson, <a href='http://blog.phatboyg.com'>http://blog.phatboyg.com</a>

"RoundhousE integration was straight forward, and it has saved the team on more than one occasion. We have a team rule to not modify ddl scripts after being committed to source control; any new changes must be carried by a new script. With RoundhousE, the tool itself enforces the rule and warns the developer when they test changes to the database..." - Elias Rangel<br>
<br>
"Great Project structure, and arquitecture. Testing it out over <code>[removed]</code> as it has a cleaner script visibility to production DBA's." - comment from a user commenting on ferventcoder.com<br>
<br>
"Been playing with RH, looks good for what we need, thank you!" - comment from a user commenting on ferventcoder.com<br>
<br>
"We are very excited about RoundhousE and the vision it takes on database change management. I can only say: Give RoundhousE a try, it’s awesome!" - Pascal Mestdach, <a href='http://pascalmestdach.blogspot.com/2010/03/database-change-management-with.html'>http://pascalmestdach.blogspot.com/2010/03/database-change-management-with.html</a>


<h2>Who's using it?</h2>

<ul><li>MassTransit <a href='http://masstransit-project.com/'>http://masstransit-project.com/</a>
</li><li>DotNetVideos <a href='http://www.dotnetvideos.net/'>http://www.dotnetvideos.net/</a>
</li><li>Bombali <a href='http://bombali.googlecode.com'>http://bombali.googlecode.com</a>
</li><li>Fortune 5 company (name withheld for privacy reasons)<br>
</li><li>Others either known (and kept private) or unknown