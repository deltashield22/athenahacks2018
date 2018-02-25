import React from 'react'
import { Button, Glyphicon } from 'react-bootstrap'

class WordExplorer extends React.PureComponent {
    constructor(props) {
        super(props);
        //number of questions in round passed in as prop
    }

    componentDidMount() {
        //serviceCall getUserInfo(score, etc.)
        //serviceCall getWordInfo
    }

    render() {
        return (
            <section>
                <div className="container">
                    <div className="row">
                        <div style={{textAlign: 'left'}} className="col-lg-4">
                            <h1>Question 4</h1>
                        </div>
                    </div>

                    <div className="row">
                        <Button type="button" bsStyle="info" bsSize="lg">
                            <Glyphicon glyph="volume-up" />
                        </Button>
                    </div>

                    <div className="row">
                        <div className="col-lg-7">
                            <div className="input-group">
                                <input style={{marginTop: 20}} type="text" className="form-control" placeholder="Missip..."/>
                                    <span className="input-group-btn">
                                        <Button style={{marginTop: 20}} type="button" bsStyle="success">Go!</Button>
                                    </span>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        )
    }

}

export default WordExplorer;