@SET results="%CD%\output\test-results"
tools\Nant\nant.exe -buildfile:nant.build test
START /d %results% Should.Facts.Results.html
START /d %results% Should.Fluent.UnitTests.Results.html