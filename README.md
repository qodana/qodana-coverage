# Coverage Tools Configuration Examples

This repository contains configuration examples for various coverage tools, specific to different programming languages and engines. Here, you will find examples for:

1. **Java and Kotlin** - Preferred: IntelliJ Coverage Agent with `ic` output format. Also includes examples for JaCoCo.
2. **JavaScript and TypeScript** - Using Jest
3. **PHP** - Using PHPUnit

## Coverage Data

Coverage data is collected and stored in the `.qodana/coverage-data` folder. Qodana Coverage Support will automatically recognize this directory and calculate the coverage data accordingly.

## Usage

Please note that this repository should be used as a reference only. Feel free to suggest improvements or changes to the configurations provided here.

## Limitations

It's important to note that JaCoCo support is limited: although the percentage of coverage would be computed and displayed, it won't be uploaded/downloaded to the cloud. For a more comprehensive solution, particularly for Java and Kotlin, consider using IntelliJ Coverage Agent with the `ic` output format instead.

For Gradle projects intending to use the `ic` format, additional actions are required to copy the resulting files to the `.qodana/coverage-data` folder.
