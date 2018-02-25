import axios from 'axios'

const wordService = {
    getListByGrade: (grade) => {
        const config = {
            method: 'GET'
        }
        return axios(`/api/words/${grade}`, config)
            .then(responseSuccessHandler)
            .catch(responseErrorHandler)
    }
  
}

const responseSuccessHandler = response => response.data;
const responseErrorHandler = error => {
    console.log(error);
    return Promise.reject(error);
}

export default wordService;