@echo off
set XDEBUG_MODE=coverage
.\vendor\bin\phpunit --coverage-clover .\.qodana\code-coverage\coverage.xml --configuration phpunit.xml --filter FooTest --test-suffix FooTest.php
