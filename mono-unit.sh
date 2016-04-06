#!/usr/bin/env bash
wget -nc https://nuget.org/nuget.exe;
mozroots --import --sync

# remove bin/Debug/SwaggerClientTest.dll
rm bin/Debug/ArtikCloudTest.dll 2> /dev/null

# install NUnit runners via NuGet
mono nuget.exe install NUnit.Runners -Version 2.6.4 -OutputDirectory testrunner

# build the solution and run the unit test
xbuild ArtikCloudTest.sln && \
mono ./testrunner/NUnit.Runners.2.6.4/tools/nunit-console.exe bin/Debug/ArtikCloudTest.dll
