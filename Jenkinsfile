pipeline {
    agent any

    stages {
        stage ('Build Image') {
            steps {
                script {
                    dockerapp = docker.build("julioveiga/buber-dinner", '-f ./src/Dockerfile ./src')
                }
            }
        }
    }
}
