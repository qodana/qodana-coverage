@echo off
set XDEBUG_MODE=coverage
.\vendor\bin\phpunit --coverage-clover .\.qodana\coverage-data\coverage.xml --configuration phpunit.xml --filter FooTest --test-suffix FooTest.php