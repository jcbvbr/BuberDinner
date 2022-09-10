pipeline {
    agent any

    stages {
        stage {
            steps {
                script {
                    dockerapp = docker.build("julioveiga/buber-dinner", '-f ./BuberDinner.Api/Dockerfile ./src')
                }
            }
        }
    }
}
